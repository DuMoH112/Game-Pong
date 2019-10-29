using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;

    public float speed = 10;

    public Rigidbody2D rb;

    void Start() {

    }

    void Update()
    {
        if (Input.GetKey(moveUp))
        {   
            rb.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(moveDown))
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
