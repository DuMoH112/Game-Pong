using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.name == "Ball")
        {
            string wallName = gameObject.name;
            GetComponent<AudioSource>().Play();
            GameManager.Score(wallName);
            other.gameObject.SendMessage ("ResetBall");
        }
    }
}
