using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevelAgain : MonoBehaviour {
    float timer = 0f;

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            timer += Time.deltaTime;
            if ((timer >= 2f))//if enter has been more than 2 seconds
            {
                SceneManager.LoadScene("FV Infinite");
            }
        }
            
    }
}
