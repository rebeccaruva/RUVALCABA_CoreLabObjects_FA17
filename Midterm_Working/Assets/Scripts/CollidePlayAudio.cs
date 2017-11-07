using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayAudio : MonoBehaviour
{

    AudioSource myAudio;
    //int audioCounter = 0;

    // Use this for initialization
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //when collides with room's box collider
    void OnTriggerEnter(Collider other)
    {
        if (!myAudio.isPlaying)
        {
            myAudio.Play();
        }
    }
}
