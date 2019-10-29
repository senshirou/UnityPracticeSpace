using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqPractice : MonoBehaviour
{
    int[] scores = { 30, 100, 6, 50, 34, 60, 12, 90, 46, 20 };
    // Start is called before the first frame update
    void Start()
    {
        int redCount = scores.Count(score => score <= 30);
        Debug.Log(redCount);
        var one = scores.Take(3);
        Debug.Log(one); //3番目の値を取得


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
