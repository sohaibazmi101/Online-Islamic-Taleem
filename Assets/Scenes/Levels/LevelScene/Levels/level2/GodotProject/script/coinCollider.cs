using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollider : MonoBehaviour
{


    private bool isTouching;

    private Animator coinAnim;

    protected static int score = 0;



    void Start()
    {
        coinAnim = GetComponent<Animator>();
    }

    void Update()
    {

        

       
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        isTouching = true;
        coinAnim.SetBool("isTouching", isTouching);


    }
}
