using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingEnd : MonoBehaviour {

    Camera cam;
    Animator fall;
    AudioSource myAudio;

    bool audioPlayed;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        fall = GetComponent<Animator>();
        myAudio = GetComponent<AudioSource>();
        audioPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //when player hits the ground, make something happen
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("we collided!!");
        if (cam.isActiveAndEnabled && fall.isActiveAndEnabled) {
            //Debug.Log("I'm working!!");
        } else if (!cam.isActiveAndEnabled && !fall.isActiveAndEnabled) {
            fall.enabled = true;
            cam.enabled = true;
            //Debug.Log("I enabled them!");
        }

        if (myAudio.isPlaying == false && audioPlayed == false)
        {
            myAudio.Play();
            audioPlayed = true;
        }
    }
}