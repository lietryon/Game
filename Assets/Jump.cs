using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        jump();
    }

    void jump() 
    { 
        if (Input.GetKeyDown(KeyCode.Space)) { 
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }
    } 
}
