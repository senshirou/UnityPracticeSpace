using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{

    ScoreControl Score_control;
    
    int Score_point;
    // Start is called before the first frame update
    void Start()
    {
        Score_control = GameObject.Find("ScoreControl").GetComponent<ScoreControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Score_control.ScorePoint(100);
        

        
    }
}
