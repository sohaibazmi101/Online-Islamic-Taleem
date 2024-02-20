using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{

    public float speed = 8f;
    public float jumpSpeed = 12f;

    private float direction = 0f;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator playerAnimator;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);


        direction = Input.GetAxis("Horizontal");
        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            player.transform.localScale = new Vector2(0.3f, 0.3f);
        }
        else if (direction < 0)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            player.transform.localScale = new Vector2(-0.3f, 0.3f);
        }
        else
        {
            player.velocity = new Vector2(0f, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }

        playerAnimator.SetFloat("speed", Mathf.Abs(player.velocity.x));
        playerAnimator.SetBool("onground", isTouchingGround);
    }



}
