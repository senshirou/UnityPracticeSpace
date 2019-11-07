using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateEvent2R : MonoBehaviour
{

    [SerializeField] private DelegateEvent2S Dele2s;
    // Start is called before the first frame update

    void OnEnable()　//スクリプトがロードされた時に呼び出される。
    {
        Dele2s.TestAc += TestAction;
        
    }

    void OnDisable() //スクリプトがリロードされた時に呼び出される（再生ボタン解除で呼び出される）。
    {
        Dele2s.TestAc -= TestAction;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestAction()
    {
        Debug.Log("kita");
    }
}
