using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ScoreControl : MonoBehaviour
{ 
    //ポイント反映用テキスト
    [SerializeField] Text Hiscore; //ハイスコアのテキスト
    [SerializeField] Text Score;　 //スコアのテキスト
    [SerializeField] Text second_ScoreText; //2位
    

    //スコアのポイント
    public int HiscoreP;　//1位のポイント
    public int SecondP;   //2位のポイント
    int Score_point;    　//現在のポイント
    public List<int> lists;　//リストを定義

    // Start is called before the first frame update
    void Start()
    {
        //1位、2位のスコア呼び出しとテキストに表示
        HiscoreP = PlayerPrefs.GetInt("HighScore");　//HighScoreの情報を呼び出し
        SecondP = PlayerPrefs.GetInt("SecondScore"); //SecoundScoreの情報呼び出し
        lists = new List<int> { HiscoreP, SecondP};　//listに1位と2位スコアの代入
        Hiscore.text = HiscoreP.ToString();     　　 //1位のポイントをテキスト化
        second_ScoreText.text = SecondP.ToString();  //2位のポイントをテキスト化

    }

    //アプリ終了時の操作
    private void OnDestroy()
    {
        
        //リストに現在のスコアを代入。
        lists.Add(Score_point);
        Debug.Log(string.Join(",", lists));

        //listsの中身を降順にする。
        var ScoreResult = lists.OrderByDescending(s => s).ToArray();

        //1位・2位のスコアをlistから取り出し、リストの[2]を消す。
        HiscoreP = ScoreResult[0];
        SecondP = ScoreResult[1];
        lists.RemoveAt(2);

        //PlayerPrefsで1位2位のスコアをセット
        PlayerPrefs.SetInt("HighScore", HiscoreP);
        PlayerPrefs.SetInt("SecondScore", SecondP);

        
        Debug.Log(string.Join(",", ScoreResult)); //ScoreResult確認用
        Debug.Log(string.Join(",", lists));       //lists確認用

        //PlaerPrefs.SetIntの保存
        PlayerPrefs.Save();

    }

    public void ScorePoint(int point)
    {
        Score_point += point;   //Scoreにポイントを追加。
        Score.text = Score_point.ToString();　//Scoreのポイントをテキスト表示。

        if (Score_point > HiscoreP) //スコアがハイスコアを超えたときの処理
        {
            HiscoreP += point;  //ハイスコアにポイントを追加
            Hiscore.text = HiscoreP.ToString();　//ハイスコアをテキスト表示
        }
        
    }



    public void HiscoreDelete()
    {


        if (HiscoreP >= 300) //Hiscoreが300を超えたら実行
        {
            PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        }
        Debug.Log(HiscoreP);
        PlayerPrefs.Save();
        //アプリ終了時のタイミングで保存
    }

}
