using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest : MonoBehaviour
{
    [SerializeField] ActionInput m_actionInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        m_actionInput.AnyKeyDown += action;　//OnEnableの時Actionメソッドの登録
    }

    void OnDisable()
    {
        m_actionInput.AnyKeyDown -= action;　//OnEnableの時Actionメソッドの削除
    }

    // Update is called once per frame
    void action()
    {
        Debug.Log("Fire");
    }
}
