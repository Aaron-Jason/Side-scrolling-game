using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    public PlayerController controller;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            controller.isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            controller.isGrounded = false;
        }
    }
}
