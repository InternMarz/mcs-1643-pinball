using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
    public int points = 500;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
            gameObject.SetActive(false);
        }
    }
}
