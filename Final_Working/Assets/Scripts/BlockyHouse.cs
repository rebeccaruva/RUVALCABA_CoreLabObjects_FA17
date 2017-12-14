using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockyHouse : MonoBehaviour
{
    AudioSource door;
    float timer = 0;
   // string[] sceneArray = { "FV Stairs" , "FV Infinite"};

    void Start()
    {
        door = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            door.Play();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (door.isPlaying)
        {
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                SceneManager.LoadScene("FV Infinite");
               // string sceneToRun = sceneArray[Random.Range(0, sceneArray.Length - 1)];
                //SceneManager.LoadScene(sceneToRun);
                
            }
        }
    }
}
