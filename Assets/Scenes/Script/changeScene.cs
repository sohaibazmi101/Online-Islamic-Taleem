using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{

    public int scene_no = 2;

    public void change_to_level_selection()
    {
        SceneManager.LoadScene(scene_no);
    }

}
