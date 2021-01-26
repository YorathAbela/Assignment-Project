using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball hit an Obstacle");
        //Show death screen when ball hits obstacle
        //Show button to reload scene
        //SceneManager.LoadScene(0); 
        GameManager.singleton.RestartLevel();
    }
}
