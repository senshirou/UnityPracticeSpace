using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ScoreControl2 : MonoBehaviour
{

    public List<int> ScoreResult;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            ScoreResult[i] = PlayerPrefs.GetInt($"Score{i}");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
