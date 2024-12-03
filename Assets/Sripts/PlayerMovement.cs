using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = Vector3.zero;
        Vector2 force = rb.velocity;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force.x += speed;
        }

        rb.velocity = force;

        if (transform.position.x < -8)
        {
            transform.position = new Vector2(-8, transform.position.y);
        }

        if (transform.position.x > 8)
        {
            transform.position = new Vector2(8, transform.position.y);
        }
    }
}
