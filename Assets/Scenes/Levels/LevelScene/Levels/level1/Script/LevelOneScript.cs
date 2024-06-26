using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneScript : MonoBehaviour
{


public float speed = 5f;
public float jumpSpeed = 8f;
private float direction = 0f;
private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator playerAnimation;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    void Update()
    {

        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        direction = Input.GetAxis("Horizontal");
        if(direction > 0f){
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            transform.localScale = new Vector2(0.2487f, 0.2487f);
        }
        else if(direction < 0){
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            transform.localScale = new Vector2(-0.2487f, 0.2487f);
        }
        else{
            player.velocity = new Vector2(0f, player.velocity.y);
        }

        if(Input.GetButtonDown("Jump") && isTouchingGround){
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }

        playerAnimation.SetFloat("Speed", Mathf.Abs(player.velocity.x));
        playerAnimation.SetBool("onGround", isTouchingGround);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
