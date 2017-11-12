using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 10f;

	// Use this for initialization
	void Start () {
        //turn off cursor so you don't see it in screen and locks it in game window
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        
        // keep movement smooth and in time with update
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        
        //push x and z axis
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}
}
