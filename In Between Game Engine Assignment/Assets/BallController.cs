using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private bool ignoreNextCollision;

    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

     private void OnCollisionEnter2D(Collision2D other) {
        
        Debug.Log("Ball touched something");
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
