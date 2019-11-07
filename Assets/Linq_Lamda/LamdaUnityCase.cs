using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Linq;

public class LamdaUnityCase : MonoBehaviour
{
    GameObject button;
    GameObject cube;
    public List<string> lists; //listsを定義する。

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            button = GameObject.Find("Button");
            string tmp = i.ToString();
            button.GetComponent<Button>().onClick.AddListener(() => { Hello(tmp); }); //()の引数指定は不可。


            
        }

        



        lists.Add("tas");　//listsに"tas"を加える。
        lists.Add("kas");  //listsに"kas"を加える。
        lists.Add("mas");　//listsに"mas"を加える。
        lists.Remove("tas");  //listに"tas"を消去。
        int b = lists.Count;　//bはリストのカウント数。


        lists.ForEach(a => Debug.Log(a));　//リストのデバッグログ
        Debug.Log("リストは" + b + "個"); //カウントのデバッグログ


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hello(string str)
    {
        Debug.Log("Hello" + str + "!");
    }
}
