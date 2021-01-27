using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public BallController target;
    private float offset;

    // Awake method starts when camera Controller awakes
    void Awake () {
        offset = transform.position.y - target.transform.position.y;
    }

    // Update is called once per frame
    void Update () {
        Vector3 curPos = transform.position;
        curPos.y = target.transform.position.y + offset;
        transform.position = curPos;
    }
}