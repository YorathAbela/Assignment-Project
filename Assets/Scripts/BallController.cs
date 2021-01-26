using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private bool ignoreNextCollision;
    public Rigidbody rb;
    private Vector3 startPos;


    // Start is called before the first frame update
    void Awake()
    {
        startPos = transform.position;
    }

    private void OnCollisionEnter(Collision collision) {

        //Debug.Log("Ball touched something");

        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up, ForceMode.Impulse);

        ignoreNextCollision = true;
        Invoke ("AllowCollision", .2f);

    }

    private void AllowCollision(){
        ignoreNextCollision = false;
    }

    public void ResetBall(){
        transform.position = startPos;
    }
}
