using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreControl : MonoBehaviour
{
<<<<<<< HiscoreTest
    [SerializeField] Text Hiscore;
    [SerializeField] Text Score;
=======
    [SerializeField] Text Hiscore; //ハイスコアのテキスト
    [SerializeField] Text Score;　 //スコアのテキスト
    [SerializeField] Text second_ScoreText; //2位
    [SerializeField] Text Third_ScoreText;   //3位

    //[SerializeField] Button DeleteButton; //ハイスコアを消すボタン
    public int HiscoreP;　//ハイスコアのポイント
    public int SecondP;
    public int ThirdP;
    public int ForthP;
    int Score_point; //スコアのポイント
    public List<int> lists;

>>>>>>> local

    int Hiscore_point;
    int Score_point;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HiscoreTest
        
=======
        lists = new List<int> { HiscoreP, SecondP, ThirdP, ForthP, Score_point };
        HiscoreP = PlayerPrefs.GetInt("HighScore");　//HighScoreの情報を呼び出し
        SecondP = PlayerPrefs.GetInt("SecoundScore"); //SecoundScoreの情報呼び出し
        ThirdP = PlayerPrefs.GetInt("ThirdScore"); //ThirdScoreの情報呼び出し
        Hiscore.text = HiscoreP.ToString();　　　　 //ハイスコアの情報をテキスト化
        //DeleteButton.onClick.AddListener(() => { HiscoreDelete(); }); //ハイスコアを消す。

>>>>>>> local
    }

    // Update is called once per frame
    void Update()
    {
        
<<<<<<< HiscoreTest
=======
        
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", HiscoreP); //ゲーム終了時にBallGameの内容を保存
        HiscoreDelete();
        //PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        //PlayerPrefs.Save();　                     //アプリ終了時のタイミングで保存
>>>>>>> local
    }

    public void ScorePoint(int point)
    {
        Score_point += point;
        Score.text = Score_point.ToString();

        if (Score_point >= Hiscore_point)
        {
            Hiscore_point += point;
            Hiscore.text = Hiscore_point.ToString();
        }
        
    }
<<<<<<< HiscoreTest
=======

    public void HiscoreDelete()
    {

        
        if(HiscoreP >= 300) //Hiscoreが300を超えたら実行
        {
            PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        }
        Debug.Log(HiscoreP);
        PlayerPrefs.Save();                      //アプリ終了時のタイミングで保存

    }

    
>>>>>>> local
}
