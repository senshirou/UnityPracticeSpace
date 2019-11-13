using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSample : MonoBehaviour
{
    [SerializeField] private UnityEvent m_event;
    //シリアライズ化することでPrivateでもInspectorに表示可能

    // Start is called before the first frame update
    void Start()
    {
        if(m_event == null)
        {
            m_event = new UnityEvent();
            m_event.AddListener(Ping);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown && m_event != null)
        {
            m_event.Invoke();//実行する際はUnityEvent.Invoke()
            //基本引数なしでつかうのを推奨
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }

}
