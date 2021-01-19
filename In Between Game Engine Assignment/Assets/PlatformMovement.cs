﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 targetPos;
    public bool isMoving;
    const int MOUSE = 0;
    // Use this for initialization1

    // Start is called before the first frame update
    void Start()
    {
        
        targetPos = transform.position;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(MOUSE)) {
            
            SetTargetPosition();
        }
        if(isMoving) {

           MoveObject();
        }
    }

    void SetTargetPosition() {

        Plane plane = new Plane (Vector3.up,transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;
        if(plane.Raycast(ray, out point ))
        targetPos = ray.GetPoint (point);

        isMoving = true;
    }

    void MoveObject () {

        transform.LookAt (targetPos);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
        isMoving = false;
        Debug.DrawLine (transform.position, targetPos, Color.red);
    }

}
