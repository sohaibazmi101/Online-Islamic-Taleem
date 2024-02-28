using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveLevel6 : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private Animator anim;
    public float speed = 5f;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // Get input axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Determine movement direction
        bool isMovingForward = vertical > 0.1f && Mathf.Abs(horizontal) < 0.1f;
        bool isMovingBackward = vertical < -0.1f && Mathf.Abs(horizontal) < 0.1f;
        bool isMovingRight = horizontal > 0.1f && Mathf.Abs(vertical) < 0.1f;
        bool isMovingLeft = horizontal < -0.1f && Mathf.Abs(vertical) < 0.1f;

        // Set velocity based on movement direction
        Vector2 movement = Vector2.zero;

        if (isMovingForward)
        {
            movement += Vector2.up * speed;
        }
        else if (isMovingBackward)
        {
            movement -= Vector2.up * speed;
        }

        if (isMovingRight)
        {
            movement += Vector2.right * speed;
        }
        else if (isMovingLeft)
        {
            movement -= Vector2.right * speed;
        }

       
        playerRigidbody.velocity = movement;

        
        anim.SetBool("isMovingForward", isMovingForward);
        anim.SetBool("isMovingBack", isMovingBackward);
        anim.SetBool("isMovingRight", isMovingRight);
        anim.SetBool("isMovingLeft", isMovingLeft);
    }
}
