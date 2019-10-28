using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballshot : MonoBehaviour
{
    [SerializeField] GameObject Sphereblue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Sphereblue, transform.localPosition, Quaternion.identity);
        }
        
    }
}
