using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private static int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "alif" && score == 0)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("alif"),0.5f);
        }
        else if(collision.tag == "baa" && score == 5)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("baa"),0.5f);
        }

        else if (collision.tag == "taa" && score == 10)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("taa"),0.5f);
        }

        else if (collision.tag == "saa" && score == 15)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("saa"),0.5f);
        }

        else if (collision.tag == "jeem" && score == 20)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("jeem"), 0.5f);
        }

        else if (collision.tag == "hhaa" && score == 25)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("hhaa"), 0.5f);
        }

        else if (collision.tag == "khaah" && score == 30)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("khaah"), 0.5f);
        }

        else if (collision.tag == "daal" && score == 35)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("daal"), 0.5f);
        }

        else if (collision.tag == "zaal" && score == 40)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("zaal"), 0.5f);
        }

        else if (collision.tag == "raa" && score == 45)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("raa"), 0.5f);
        }

        else if (collision.tag == "zaa" && score == 50)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("zaa"), 0.5f);
        }

        else if (collision.tag == "seen" && score == 55)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("seen"), 0.5f);
        }

        else if (collision.tag == "sheen" && score == 60)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("sheen"), 0.5f);
        }

        else if (collision.tag == "suad" && score == 65)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("suad"), 0.5f);
        }

        else if (collision.tag == "zuad" && score == 70)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("zuad"), 0.5f);
        }

        else if (collision.tag == "tua" && score == 75)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("tua"), 0.5f);
        }

        else if (collision.tag == "zua" && score == 80)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("zua"), 0.5f);
        }

        else if (collision.tag == "ain" && score == 85)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("ain"), 0.5f);
        }

        else if (collision.tag == "ghain" && score == 90)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("ghain"), 0.5f);
        }

        else if (collision.tag == "faa" && score == 95)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("faa"), 0.5f);
        }

        else if (collision.tag == "qaaf" && score == 100)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("qaaf"), 0.5f);
        }

        else if (collision.tag == "kaaf" && score == 105)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("kaaf"), 0.5f);
        }

        else if (collision.tag == "laam" && score == 110)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("laam"), 0.5f);
        }

        else if (collision.tag == "meem" && score == 115)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("meem"), 0.5f);
        }

        else if (collision.tag == "noon" && score == 120)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("noon"), 0.5f);
        }

        else if (collision.tag == "wao" && score == 125)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("wao"), 0.5f);
        }

        else if (collision.tag == "hey" && score == 130)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("hey"), 0.5f);
        }

        else if (collision.tag == "hamza" && score == 135)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("hamza"), 0.5f);
        }

        else if (collision.tag == "yaa" && score == 140)
        {
            score += 5;
            Destroy(GameObject.FindGameObjectWithTag("yaa"), 0.5f);
        }


    }


}
