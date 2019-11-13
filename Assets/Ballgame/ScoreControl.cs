using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class ScoreControl : MonoBehaviour
{


    

    [SerializeField] Text Hiscore; //ハイスコアのテキスト
    [SerializeField] Text Score;　 //スコアのテキスト
    [SerializeField] Text second_ScoreText; //2位
    [SerializeField] Text Third_ScoreText;   //3位

    //[SerializeField] Button DeleteButton; //ハイスコアを消すボタン
    public int HiscoreP;　//ハイスコアのポイント
    public int SecondP = 100;
    public int ThirdP = 300;
    public int ForthP;
    int Score_point; //スコアのポイント
    public List<int> lists;
    public List<int> lists2;



    int Hiscore_point;
    // Start is called before the first frame update
    void Start()
    {

        

        lists = new List<int> { HiscoreP, SecondP, ThirdP};
        HiscoreP = PlayerPrefs.GetInt("HighScore");　//HighScoreの情報を呼び出し
        SecondP = PlayerPrefs.GetInt("SecondScore"); //SecoundScoreの情報呼び出し
        ThirdP = PlayerPrefs.GetInt("ThirdScore"); //ThirdScoreの情報呼び出し
        Hiscore.text = HiscoreP.ToString();　　　　 //ハイスコアの情報をテキスト化
        //DeleteButton.onClick.AddListener(() => { HiscoreDelete(); }); //ハイスコアを消す。
        
        

    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("BallGame", HiscoreP); //ゲーム終了時にBallGameの内容を保存
        //PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        PlayerPrefs.Save();　                     //アプリ終了時のタイミングで保存
    }

    private void OnDestroy()
    {
        lists.Add(Score_point);
        PlayerPrefs.SetInt("HighScore", HiscoreP); //ゲーム終了時にBallGameの内容を保存
        PlayerPrefs.SetInt("SecondScore", SecondP);
        PlayerPrefs.SetInt("ThirdScore", ThirdP);
        var ScoreResult = lists.OrderByDescending(s => s).ToArray();
        var SScore = new List<int[]>();
        SScore.Add(ScoreResult);
        SScore.RemoveAt(3);
        Debug.Log(string.Join(",", SScore));
        PlayerPrefs.Save();

        //HiscoreDelete();
        //PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        //PlayerPrefs.Save();　                     //アプリ終了時のタイミングで保存

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

        
        if(HiscoreP >= 300) //Hiscoreが300を超えたら実行
        {
            PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        }
        Debug.Log(HiscoreP);
        PlayerPrefs.Save();                      //アプリ終了時のタイミングで保存

}
