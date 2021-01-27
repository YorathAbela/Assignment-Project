using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField]
    public float speed = 11f;
    public Vector3 targetPos;
    public bool isMoving;
    const int MOUSE = 0;
    [SerializeField]
    private GameObject _mainCamera;
    // Use this for initialization1
    private bool _randomizeHeight = true;

    // Start is called before the first frame update
    void Start()
    {
        
        // targetPos = transform.position;
        // isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButton(MOUSE)) {
            
        //     SetTargetPosition();
        // }
        // if(isMoving) {

        //    MoveObject();
        // }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }        
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if(transform.position.y > _mainCamera.transform.position.y + 6)
        {
            if(_randomizeHeight)
            {
                float randomXPosition = Random.Range(-6f,6f);
            Debug.Log("The random position is: " + randomXPosition);
            transform.position = new Vector3(randomXPosition,transform.position.y - 15,transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x,transform.position.y - 15,transform.position.z);
            }
        }
    }

}
