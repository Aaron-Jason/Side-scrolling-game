using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusPoint : MonoBehaviour
{
    public int points = -10;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.scoreManager.MinusScore(points);
            Debug.Log("Score: " + GameManager.instance.scoreManager.tottalScore);
        }
    }
}
