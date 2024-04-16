using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int points = 5;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        audioManager.PlaySFX(audioManager.point);

        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.scoreManager.AddScore(points);
            Debug.Log("Score: " + GameManager.instance.scoreManager.tottalScore);
            this.gameObject.SetActive(false);
        }
    }
}
