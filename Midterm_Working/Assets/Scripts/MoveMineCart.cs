using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMineCart : MonoBehaviour
{

    Animator move;
    AudioSource myAudio;

    bool audioPlayed;

    // Use this for initialization
    void Start()
    { 
        move = GetComponent<Animator>();
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
        //Debug.Log("we collided!!");
        if (move.isActiveAndEnabled)
        {
            //Debug.Log("I'm working!!");
        }
        else if (!move.isActiveAndEnabled)
        {
            move.enabled = true;
            //Debug.Log("I already moved");
        }

        if (myAudio.isPlaying == false && audioPlayed == false)
        {
            myAudio.Play();
            audioPlayed = true;
            //Debug.Log("Audio is playing");
        }
    }
}