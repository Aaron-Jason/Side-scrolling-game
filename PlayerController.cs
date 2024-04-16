using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpForce = 13f;
    public float horizontal;
    public bool isFacingright = true;
    public bool isGrounded;
    public Animator animator;

    public Transform groundChek;
    public LayerMask groundLayer;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager =GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            CharacterMovement();
            Flip();
            AniamtionWalk();
            AnimationJump();
        }

    }
    private void CharacterMovement()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            audioManager.PlaySFX(audioManager.jump);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }
    private void AnimationJump()
    {
        if (isGrounded == false)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }
    private void AniamtionWalk()
    {
        if (horizontal > 0f)
        {
            animator.SetBool("isWalking", true);
        }
        else if (horizontal < 0f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
    private void Flip()
    {
        if (isFacingright && horizontal < 0f || !isFacingright && horizontal > 0f)
        {
            isFacingright = !isFacingright;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
