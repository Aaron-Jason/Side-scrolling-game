using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    AudioManager audioManager;
    public Canvas canvasToActivate;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            ActivateCanvas();
            audioManager.PlaySFX(audioManager.finish);
            gameState();
            Time.timeScale = 0f;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            Time.timeScale = 1f;
        }

    }
    private void ActivateCanvas()
    {
        canvasToActivate.gameObject.SetActive(true);
    }

    private void gameState()
    {
        GameManager.instance.gameState = GameState.PAUSED;
    }
}

