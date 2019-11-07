using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateEvent2S : MonoBehaviour
{
    public event Action TestAc;　//イベントアクションを定義する。

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && TestAc != null)
        {
            TestAc() ;
        }
    }
}
