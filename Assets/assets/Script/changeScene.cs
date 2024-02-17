using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{

    public void change_to_level_selection()
    {
        SceneManager.LoadScene(2);
    }

    public void change_to_level_one(){
        SceneManager.LoadScene(3);
    }

}
