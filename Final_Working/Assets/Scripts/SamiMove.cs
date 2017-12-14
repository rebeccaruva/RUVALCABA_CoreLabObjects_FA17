using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamiMove : MonoBehaviour {

    //public float moveSpeed = 10f;

    public float speed = 16f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moves Forward and back along z axis (up/down)
        //transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //Moves Left and right along x Axis (left/right)
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = (movement * speed);

    }
}
