using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ballStart : MonoBehaviour
{

    Rigidbody2D rb;
    float ang;
    public bool dead = false;
    float dtime;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ang = Random.Range(-3.0f, 3.0f);
        rb.velocity = new Vector3(ang, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // on death
        if (transform.position.y < -5.5f)
        {
            // reset
            rb = GetComponent<Rigidbody2D>();
            transform.position = new Vector3(4.28f, 0, 0);
            // pause
            rb.velocity = new Vector3(0, 0, 0);
            dead = true;
            dtime = Time.time + 2.0f;

        }

        //play
        if (Time.time > dtime && dead == true)
        {
            rb = GetComponent<Rigidbody2D>();
            ang = Random.Range(-3.0f, 3.0f);
            rb.velocity = new Vector3(ang, -speed, 0); ;
            dead = false;
        }
    }
}
