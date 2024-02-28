using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerLevel5 : MonoBehaviour
{
    public float speed = 8f;
    public float jumpSpeed = 12f;

    private float direction = 0f;
    private Rigidbody2D player;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
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

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }
}
