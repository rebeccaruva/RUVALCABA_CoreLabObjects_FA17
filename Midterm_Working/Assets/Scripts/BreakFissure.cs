using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakFissure : MonoBehaviour {

    Rigidbody[] rb;

	// Use this for initialization
	void Start () {
        rb = GetComponentsInChildren<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //when player hits the ground, make something happen to the floors
    void OnTriggerEnter(Collider other) {
        for (int i = 0; i < rb.Length; i++) {
            rb[i].isKinematic = false;
            rb[i].useGravity = true;
        }
    }

    private void OnMouseDown()
    {
    }
}
