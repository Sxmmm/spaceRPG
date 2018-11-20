﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform LookAt;
    public float boundX = 2.0f;
    public float boundY = 1.5f;
    public float speed = 0.15f;

    private Vector3 desiredPosition;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float dx = LookAt.position.x - transform.position.x;
        if(dx > boundX || dx < -boundX)
        {
            if(transform.position.x < LookAt.position.x)
            {
                delta.x = dx - boundX;
            }
            else
            {
                delta.x = dx + boundX;
            }
        }

        float dy = LookAt.position.y - transform.position.y;
        if (dy > boundY || dy < -boundY)
        {
            if (transform.position.y < LookAt.position.y)
            {
                delta.y = dy - boundY;
            }
            else
            {
                delta.y = dy + boundY;
            }
        }

        desiredPosition = transform.position + delta;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed);
    }
}
