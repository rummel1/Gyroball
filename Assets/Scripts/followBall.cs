using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followBall : MonoBehaviour {


    public GameObject ball;
    public float smoothSpeed = 0.25f;
    private Quaternion desiredRotation;

    void Update() {
        Vector3 ballPosition = ball.transform.position;

        transform.position = ballPosition + new Vector3(0, 1f, 0);

        Vector3 ballMovementDirection = ball.GetComponent<Rigidbody>().velocity.normalized;
        desiredRotation = Quaternion.LookRotation(ballMovementDirection);

        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed);
    }
}