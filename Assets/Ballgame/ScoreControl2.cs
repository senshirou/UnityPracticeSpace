using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ScoreControl2 : MonoBehaviour
{
    public int Myscore;
    int score0, score1, score2, score3, score4, score5, score6, score7, score8,score9;
    List<int> ScoreResult;
    // Start is called before the first frame update
    void Start()
    {
        ScoreResult = new List<int> { score0, score1, score2, score3, score4, score5, score6, score7, score8, score9 };
        for (int i = 0; i < ScoreResult.Count; i++)
        {
            ScoreResult[i] = PlayerPrefs.GetInt($"Score{i}");
        }
        Debug.Log(string.Join(",",ScoreResult));
    }

    void OnDisable()
    {
        ScoreResult.Add(Myscore);
        var ScoreResults = ScoreResult.OrderByDescending(s => s).ToArray();
        for (int i = 0; i < ScoreResult.Count; i++)
        {
            PlayerPrefs.SetInt($"Score{i}", ScoreResults[i]);
        }
        ScoreResult.Remove(10);
        Debug.Log(string.Join(",", ScoreResults));

        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ++Myscore;
            Debug.Log(Myscore);
        }
    }
}
