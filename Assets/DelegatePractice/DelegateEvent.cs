using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //使用する際宣言が必要

public class DelegateEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent Cubes;

    void Start()
    {
        if(Cubes == null)
        {
            Cubes = GetComponent<UnityEvent>();
            Cubes.AddListener(Nocube);
        }

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Cubes.Invoke();
        }
    }

    public void Nocube()
    {
        Debug.Log("Nocube");
    }

}
