using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqPractice : MonoBehaviour
{
    int[] scores = { 30, 100, 6, 50, 34, 60, 12, 90, 46, 20 };
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        int RedCount = scores.Count(score => score <= 30);　//scores配列30以下のカウント
        Debug.Log(RedCount);

        var one = scores.Take(3);　//3番目の値を取得
        foreach(var three in one)
        {
            Debug.Log(three);
        }

        int MaxCount = scores.Max(); //最大値を取得
        Debug.Log("最大値は" + MaxCount);

        bool AnyCount = scores.Any(Ascore => Ascore <= 20);　//20以下が含まれているか判定。
        Debug.Log(AnyCount);

        var TakeWhileCount = scores.TakeWhile(Twhile => Twhile >= 20);　//20以上の値を表示。
        foreach(var Twc in TakeWhileCount)
        {
            
            Debug.Log("20以上の値その" + count  + ":" + Twc);
            count++;
        }
        

        var ScoreOrder = scores.OrderBy(v => v); //小さい順に並び替え
        foreach(var Order in ScoreOrder)
        {
            Debug.Log(count +"番目："+Order);
            count++;
        }
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
