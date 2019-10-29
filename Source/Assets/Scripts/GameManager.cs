using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore01 = 0;
    static int playerScore02 = 0;

    public int winner = 10;

    public GUISkin theSkin;

    Transform ball;

    void Start() {
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    // Start is called before the first frame update
    public static void Score(string wallName)
    {
        if (wallName == "rightWall")
        {
            playerScore01++;
        }
        else if (wallName == "leftWall")
        {
            playerScore02++;
        }
    }
    
    void OnGUI ()
    { 
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2-150, 20, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2+150, 20, 100, 100), "" + playerScore02);
    
        if (playerScore01 >= winner)
        {
            Win(1);
        }
        else if (playerScore02 >= winner)
        {
            Win(2);
        }
    }

    void Win(int player)
    {
        ball.SendMessage ("StopBall");
        GUI.Label(new Rect(Screen.width/2 - 130, 100, 300, 100), "GAME OVER");
        GUI.Label(new Rect(Screen.width/2 - 153, 140, 400, 100), "WIN PLAYER " + player);
        if (GUI.Button (new Rect(Screen.width/2 - 62, 200, 121, 53), "RESET"))
        {
            playerScore01 = 0;
            playerScore02 = 0;
            ball.SendMessage ("ResetBall");
        }
    }

    void Update() {
        
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
