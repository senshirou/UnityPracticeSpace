using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;　//Action型を使うのに必要

public class ActionInput : MonoBehaviour
{
    public event Action AnyKeyDown; //Action型の定義

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.anyKeyDown && AnyKeyDown != null)
        {
            AnyKeyDown();
        }
        
    }
}
