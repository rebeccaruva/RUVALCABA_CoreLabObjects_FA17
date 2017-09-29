using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveFP : MonoBehaviour {
    //Declare variable for speed of rotation and movement
    public float moveSpeed;
    public float rotateSpeed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        moveSpeed = .3f;
        rotateSpeed = 1.5f;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //user will move forward and backwards with up and down arrows
        float move = Input.GetAxisRaw("Vertical") * moveSpeed;

        //user will rotate left and right with left and right arrows
        float rotate = Input.GetAxisRaw("Horizontal") * rotateSpeed;

        Debug.Log(move + ", " + rotate);

        //we want to use:
        //up arrow and w to move forward
        //down arrow and s to move backwards
        //left arrow and a to rotate left
        //right arrow and d to rotate right

        //we want to move on z-axis and rotate around the y-axis
        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);

        //make camera jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.useGravity = true;
            rb.AddForce(transform.up * 300f);
        }
//        else
//        {
//            rb.useGravity = false;
//        }
    }
}
