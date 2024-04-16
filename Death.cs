using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Vector2 startPos;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Obstacle")
        {
            audioManager.PlaySFX(audioManager.death);
            Die();
        }
    }

    void Die()
    {
        transform.position = startPos;
    }

}