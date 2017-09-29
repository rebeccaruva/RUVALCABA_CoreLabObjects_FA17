using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnBounce : MonoBehaviour {

    AudioSource myAudio;

	// Use this for initialization
	void Start () {
        myAudio = GetComponent<AudioSource>();
	}
	
	// runs when collision happens
	void OnCollisionEnter (Collision collision) {
        myAudio.Play();
	}

    void OnCollisionStay (Collision collision) {
        if (myAudio.isPlaying == false)
        {
            myAudio.Play();
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (myAudio.isPlaying == false)
        {
            myAudio.Play();
        }
    }
}
