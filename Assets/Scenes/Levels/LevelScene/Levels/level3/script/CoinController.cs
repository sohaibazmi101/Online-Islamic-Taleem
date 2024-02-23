using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    public GameObject player;

    private Animator gotPoints;
    private static int score = 0;

    void Start()
    {
        player = GetComponent<GameObject>();
        gotPoints = GetComponent<Animator>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            if(gameObject.tag == "zabar")
            {
                gotPoints.SetBool("GotTheCorrect", true);
                score += 10;
                Destroy(gameObject, 1);
            }
            else if (gameObject.tag == "enemy")
            {
                gotPoints.SetBool("Failed", true);
                score -= 10;
                Destroy(gameObject, 1);
            }
            Debug.Log("Total Score = " + score);
        }
    }
}
