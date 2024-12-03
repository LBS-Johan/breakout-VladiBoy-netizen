using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;

    float x_speed;
    float y_speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        x_speed = 1f * speed;
        y_speed = -1f * speed;
    }

    void Update()
    {
        if (transform.position.x < -8.635f)
        {
            x_speed = 1f * speed;
        }

        if (transform.position.x > 8.635f)
        {
            x_speed = -1f * speed;
        }

        rb.velocity = Vector3.zero;
        Vector2 force = rb.velocity;

        force.x += x_speed;
        force.y += y_speed;

        rb.velocity = force;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.position.y > transform.position.y)
        {
            y_speed = -1f * speed;
        }
        if (collision.gameObject.transform.position.y < transform.position.y)
        {
            y_speed = 1f * speed;
        }

        if (collision.gameObject.transform.position.x > transform.position.x)
        {
            x_speed = -1f * speed;
        }
        if (collision.gameObject.transform.position.x < transform.position.x)
        {
            x_speed = 1f * speed;
        }
    }
}
