using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private bool ignoreNextCollision;
    public Rigidbody rb;
    private Vector3 startPos;
    public AudioSource audiosource;
    public AudioClip SoundToPlay;


    // Start is called before the first frame update
    void Awake()
    {
        startPos = transform.position;
    }

    void Start()
    {
         audiosource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision) {

        //Debug.Log("Ball touched something");
        audiosource.PlayOneShot(SoundToPlay);
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
