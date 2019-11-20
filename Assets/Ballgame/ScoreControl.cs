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
    

    //[SerializeField] Button DeleteButton; //ハイスコアを消すボタン
    public int HiscoreP;　//ハイスコアのポイント
    public int SecondP;
    
    public int ForthP;
    int Score_point; //スコアのポイント
    public List<int> lists;
    public List<int> lists2;



    int Hiscore_point;
    // Start is called before the first frame update
    void Start()
    {

        HiscoreP = PlayerPrefs.GetInt("HighScore");　//HighScoreの情報を呼び出し
        SecondP = PlayerPrefs.GetInt("SecondScore"); //SecoundScoreの情報呼び出し
        lists = new List<int> { HiscoreP, SecondP};
       
        
        Hiscore.text = HiscoreP.ToString();     //ハイスコアの情報をテキスト化
        second_ScoreText.text = SecondP.ToString();     //ハイスコアの情報をテキスト化
                                                //DeleteButton.onClick.AddListener(() => { HiscoreDelete(); }); //ハイスコアを消す。



    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    

    private void OnDestroy()
    {
        lists.Add(Score_point);
        Debug.Log(string.Join(",", lists));
        var ScoreResult = lists.OrderByDescending(s => s).ToArray();
        HiscoreP = ScoreResult[0];
        SecondP = ScoreResult[1];
        lists.RemoveAt(2);
        PlayerPrefs.SetInt("HighScore", HiscoreP); //ゲーム終了時にBallGameの内容を保存
        PlayerPrefs.SetInt("SecondScore", SecondP);
        Debug.Log(string.Join(",", ScoreResult)); //ScoreResult確認用
        Debug.Log(string.Join(",", lists));       //lists確認用
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


        if (HiscoreP >= 300) //Hiscoreが300を超えたら実行
        {
            PlayerPrefs.DeleteKey("BallGame");      //ゲーム終了時にBallGameの内容を削除
        }
        Debug.Log(HiscoreP);
        PlayerPrefs.Save();
        //アプリ終了時のタイミングで保存
    }

}
