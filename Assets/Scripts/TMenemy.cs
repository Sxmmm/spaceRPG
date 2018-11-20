using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMenemy : MonoBehaviour {

    public int health;
    public float speed;
    public float otime;
    private float time;

    private float dazedtime;
    public float odazedtime;

    private Vector3 origPos;
    
    void Start()
    {
        origPos = transform.position;
        health = 100;
    }

    void Update()
    {
        if(dazedtime <= 0)
        {
            speed = 4;
        }
        else
        {
            speed = 0;
            dazedtime -= Time.deltaTime;
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if (time <= 0)
        {
            time = otime;
            transform.position = origPos;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            time -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        dazedtime = odazedtime;
        health -= damage;
    }
}
