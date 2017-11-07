using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRig : MonoBehaviour {

    Animator anim;
    AudioSource audiom;
    int audioCounter;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        audiom = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (!anim.isActiveAndEnabled)
        {
            anim.enabled = true;
        } else if (audioCounter < 1)
        {
            audiom.Play();
            audioCounter++;
        }
    }
}
