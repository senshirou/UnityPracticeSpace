using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Lamda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Func<int, int> multiply = x => x * 100;　//戻り値と引数がある場合,<引数,戻り値>
        Debug.Log("multi is" + multiply(10));

        Func<int, bool> inboo = a => a == 1; //引数int 戻り値boolの場合の例
        Debug.Log(inboo(2));

        Func<string, string, bool> ssb = (b, c) => b + c == "helloworld";
        Debug.Log(ssb("hello", "world"));

        Func<int, string, bool> isb = (i, s) => s.Length == i;
        Debug.Log("答えは" + isb(2, "ta"));

        Action<int, int> sum = (x, y) => //戻り値なし、引数2個の場合
        {
             x = x + y;
            Debug.Log(x);
        };
        sum(2, 5);

        //Func<int a,int b> int a 引数　int b 戻り値
        //Func<int a, int c, intb> a,c　引数　int b 戻り値、2つ以上の実装方法は上の例だとmultiply = (a,c) => a * c * 100;
        //Action<int a, int b> 　int a 引数　int b 引数

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
