using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 250f);
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, 5); //destroy after 5 seconds 
	}
}
