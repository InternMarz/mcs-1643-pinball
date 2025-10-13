using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public int lives = 3;
   public GameObject ballPrefab;
    public Transform ballStart;

    public void EndBall()
    {
        lives--;
        if (lives == 0)
        {
          //show the game over
        }
        else
        {
          //instantiate a new ball at the proper position
          Instantiate(ballPrefab, ballStart.position, Quaternion.identity);
        }
    }
}
