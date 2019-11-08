using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] Text Hiscore; //ハイスコアのテキスト
    [SerializeField] Text Score;　 //スコアのテキスト
    [SerializeField] Button DeleteButton; //ハイスコアを消すボタン
    public int HiscoreP;　//ハイスコアのポイント
    int Score_point; //スコアのポイント


    // Start is called before the first frame update
    void Start()
    {
        HiscoreP = PlayerPrefs.GetInt("BallGame");　//BallGameの情報を呼び出し
        Hiscore.text = HiscoreP.ToString();　　　　 //ハイスコアの情報をテキスト化
        DeleteButton.onClick.AddListener(() => { HiscoreDelete(); }); //ハイスコアを消す。

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

    void HiscoreDelete()
    {
        Debug.Log("HiscoreDelete");
    }

    
}
