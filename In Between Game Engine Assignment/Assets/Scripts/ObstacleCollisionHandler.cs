using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ball hit an Obstacle");
        //reload the scene when ball hits an obstacle
        SceneManager.LoadScene(0);
    }
}
