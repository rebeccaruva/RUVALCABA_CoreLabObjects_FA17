using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayOnHit : MonoBehaviour {

    AudioSource myAudio;

	// Use this for initialization
	void Start () {
        myAudio = GetComponent<AudioSource>();
	}

    //runs the moment collision happens
    private void OnCollisionEnter(Collision collision) {
        // myAudio.Play();

        if (myAudio.isPlaying == false) {
            myAudio.Play();
        }

        if (myAudio.isPlaying) {
            Debug.Log("Audio is playing");
        }
    }

    //lasts during collision
    void onCollisionStay(Collision collision) {
        Debug.Log("stay");
    }

}
