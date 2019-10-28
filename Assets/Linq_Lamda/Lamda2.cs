using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Lamda2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Func<int,int, int> tastas = (x,y) => x + 2 + y;
        Debug.Log(tastas(2,5));

        Action<int,int> tameshi = (xman,yman) =>
        {
            xman = xman + 2 + yman;
            Debug.Log(xman);
        };
        tameshi(2,2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
