using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFall : MonoBehaviour {

    Rigidbody ice;
    AudioSource myaudio;
    int audioplay = 0;

	// Use this for initialization
	void Start () {
        ice = GetComponentInChildren<Rigidbody>();
        myaudio = GetComponentInChildren<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (audioplay < 1)
        {
            ice.isKinematic = false;
            ice.useGravity = true;
            myaudio.Play();
            audioplay++;
        }
    }
}
