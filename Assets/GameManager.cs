﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int best;
    public int score;

    public int currentStage = 0;

    public static GameManager singleton; 




    // Start is called before the first frame update
    void Awake()
    {
        if (singleton == null)
        singleton = this;
        else if (singleton != this)
        Destroy(gameObject); 

        best = PlayerPrefs.GetInt("Highscore");

        
    }

    public void NextLevel() {

    }
        
    public void RestartLevel() {

    }

    public void AddScore(int scoreToAdd){
        score += scoreToAdd;
        if(score > best){
            best = score;
            PlayerPrefs.SetInt("Highscore", score);

        }
    }
}
