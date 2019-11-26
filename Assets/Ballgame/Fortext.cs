using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortext : MonoBehaviour
{
    List<int> TestList;
    int sono1, sono2, sono3;
    // Start is called before the first frame update
    void Start()
    {
        TestList = new List<int> { sono1, sono2, sono3 };

        for (int i = 0; i < 3; i++)
        {
            TestList[i] = i;
            Debug.Log(i);
        }

        

        Debug.Log(string.Join(",",TestList));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
