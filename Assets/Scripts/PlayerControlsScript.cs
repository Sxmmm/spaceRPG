using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsScript : MonoBehaviour {

    public float moveSpeed = 5f;
    int direction = 1;
    float xpos;


    void Start ()
    {
        xpos = transform.position.x;
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        if (transform.position.x < xpos)
        {
            if (direction == 1)
            {
                transform.localScale = new Vector2(-1, transform.localScale.y);
                direction = -1;
            }
        }
        else if (transform.position.x > xpos)
        {
            if (direction == -1)
            {
                transform.localScale = new Vector2(1, transform.localScale.y);
                direction = 1;
            }
        }
        xpos = transform.position.x;
    }
}
