using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    
        GameManager.singleton.RestartLevel();
    }
}
