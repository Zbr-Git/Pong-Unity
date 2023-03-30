using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D myRigidbody;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        // myRigidbody = GetComponent<Rigidbody2D>();
         direction = Vector2.one.normalized; //(1,1)

    }

    private void FixedUpdate()
    {
       // myRigidbody.velocity = Vector2.one * speed;
             myRigidbody.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall")) 
        {
            direction.y = -direction.y;
        }
        else if(collision.gameObject.CompareTag("Paddle"))
        {
            speed = speed + Random.Range(0.5f, 0.1f);
            direction.x = -direction.x;
        }
    }

    
}
