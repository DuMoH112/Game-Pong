using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballSpeed;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        GoBall();    
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Player")
        {
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();
        }    
    }

    IEnumerator ResetBall()
    {
        rb.velocity = new Vector2 (0f, 0f);
        transform.position = new Vector2(0f, 0f);

        yield return new WaitForSeconds(2f);
        GoBall(); 
    }
    
    void StopBall()
    {
        rb.velocity = new Vector2 (0f, 0f);
        transform.position = new Vector2(0f, 0f);
    }

    void GoBall()
    {
        if (Random.Range(0, 10) <= 5)
        {
            
            rb.AddForce (new Vector2 (ballSpeed, 10));
        }
        else
        {
            rb.AddForce (new Vector2 (-ballSpeed, 10));
        }
    }
}
