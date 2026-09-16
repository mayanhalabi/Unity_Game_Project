using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D playerRB;

    public float playerJump;

    private bool isGrounded;

    public Transform groundCheckPoint;

    public LayerMask whatisGround;

    private Animator anim;

    private SpriteRenderer theSR;

    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        playerRB.linearVelocity =
            new Vector2(moveSpeed * Input.GetAxis("Horizontal"),
                playerRB.linearVelocity.y);

        isGrounded =
            Physics2D
                .OverlapCircle(groundCheckPoint.position, .2f, whatisGround);

        if (Input.GetButtonDown("Jump"))
            if (isGrounded)
            {
                playerRB.linearVelocity =
                    new Vector2(playerRB.linearVelocity.x, playerJump);

                AudioManager.instance.PlaySFX(10);
            }

        //anim.SetFloat("moveSpeed", playerRB.velocity.x);
        anim.SetFloat("moveSpeed", Mathf.Abs(playerRB.linearVelocity.x));
        anim.SetBool("isGrounded", isGrounded);

        if (playerRB.linearVelocity.x < 0)
        {
            theSR.flipX = true;
        }
        else if (playerRB.linearVelocity.x > 0)
        {
            theSR.flipX = false;
        }
    }
}
