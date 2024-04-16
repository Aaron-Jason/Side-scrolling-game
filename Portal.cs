using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetPos;
    public Transform playerPos;
    public bool isRange;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isRange)
        {
            playerPos.position = targetPos.position;    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRange = true;

            if (playerPos == null)
            {
                playerPos = collision.GetComponent<Transform>();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioManager.PlaySFX(audioManager.portal);
            isRange = false;
        }
    }
}
