using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] Text Hiscore;
    [SerializeField] Text Score;

    int Hiscore_point;
    int Score_point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
