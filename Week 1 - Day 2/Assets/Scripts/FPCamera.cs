using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour {
	//Declare a variable for speed
	public float moveSpeed;
	public float rotateSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = 0.0000001f;
		rotateSpeed = 3.5f;

	}

	// Update is called once per frame
	void Update () {

		float move = Input.GetAxisRaw("Vertical") * 2;
		float rotate = Input.GetAxisRaw("Horizontal") * 2;
		//used to move left, right, up and down
		//float move2 = Input.GetAxisRaw("Horizontal") * 2;

		Debug.Log(rotate);

		// floatX = 5;
		//5 / 5.0f one is an integer and the other is a float
		//unity will deal with them differently

		//moves left, right, and rotates over the y-axis

			//s and down: translates left
			//w and up: translates right
			//a and left: rotates left
			//d and right: rotates right

		transform.Translate(move, 0, 0);
		transform.Rotate(0, rotate, 0);

		//moves left, right, up, and down
		//transform.Translate(move2, 0, 0);
		//transform.Translate(0, move, 0);

		// float1 = 10.5/ 112.789/ 

	}
}
