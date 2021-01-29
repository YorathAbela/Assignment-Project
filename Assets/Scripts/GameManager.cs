using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int best;
    public int score;

    public int currentStage = 0;

    public static GameManager singleton;
    public GameObject deathMenu;

    public Text finalscore;

    public AudioSource audiosource;
    public AudioClip SoundToPlay;


    // Start is called before the first frame update
    void Awake()
    {
        if (singleton == null)
        singleton = this;
        else if (singleton != this)
        Destroy(gameObject); 

        best = PlayerPrefs.GetInt("Highscore");

    }

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void NextLevel() {

    }
        
    public void RestartLevel() {
        Debug.Log("Game Over");
        Destroy(GameObject.FindWithTag("Ball"));
        audiosource.PlayOneShot(SoundToPlay);
        finalscore.text = score.ToString ();
        deathMenu.SetActive(true);
    }

    public void AddScore(int scoreToAdd){
        score += scoreToAdd;
        if(score > best){
            best = score;
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
