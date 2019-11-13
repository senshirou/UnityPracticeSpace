using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

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

        var TakeWhileCount = scores.Where(Twhile => Twhile >= 20); //20以上の値を表示。


        foreach (var Twc in TakeWhileCount)
        {

            Debug.Log("20以上の値その" + count + ":" + Twc);
            count++;
        }


        var ScoreOrder = scores.OrderBy(v => v); //小さい順に並び替え
        foreach(var Order in ScoreOrder)
        {
            Debug.Log(count +"番目："+Order);
            count++;
        }

        var ScoreRandom = scores.OrderBy(s => Guid.NewGuid()).ToArray(); //配列をシャッフル。SystemのUsingステートメントが必要 //参考URL https://webbibouroku.com/Blog/Article/array-shuffle
        foreach (var SR in ScoreRandom)
        {
            //Debug.Log(SR);
        }

        //Guid 128ビットの整数値からなる、データを一意に識別するために用いられる識別子
        //(s => Guid.NewGuid()).ToArray()はArrayは配列、NewGuid()は新しく整数値を生成する。上のコードだとスコアの配列値を新しく生成して、配列にする。

        var ScoreRandom2 = scores.Shuffle().ToArray();
        Debug.Log(string.Join(",", ScoreRandom2));

        var test = scores.Where(score => score <= 50);
        Debug.Log(string.Join(":", test));

        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class IEnumerableExtension
{
    

    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
    {
        return collection.OrderBy(i => Guid.NewGuid());
    }

    //静的クラスは、入力パラメーターに対してのみ処理を行い、内部のインスタンス フィールドを取得したり設定したりする必要のない一連のメソッドを格納する、便利なコンテナーとして使用できます。
    //IEnumebrale<T> はforeachとLINQで処理できるようになるクラスをつくることができるインターフェース 引用元：http://garicchi.hatenablog.jp/entry/2014/09/13/200000

}




