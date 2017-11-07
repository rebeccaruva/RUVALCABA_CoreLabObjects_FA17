using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    //Animation anim;
    void Start()
    {
     
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Midterm_Fissure");
    }
}
