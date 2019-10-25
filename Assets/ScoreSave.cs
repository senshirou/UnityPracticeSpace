﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSave : MonoBehaviour
{

    public GameObject score_object = null;
    public int score_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        //スコアのロード
        score_num = PlayerPrefs.GetInt("SCORE", 0);


    }

    //削除時の処理
    void OnDestroy()
    {
        //スコアを保存
        PlayerPrefs.SetInt("SCORE", score_num);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;


        score_num += 1; //１を加算し続ける。
        
    }
}
