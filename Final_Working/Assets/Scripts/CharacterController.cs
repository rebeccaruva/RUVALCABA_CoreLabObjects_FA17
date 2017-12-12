using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 100f;
    Rigidbody rb;
    int jumpCounter = 0;

    Transform camPos;

    // Use this for initialization
    void Start()
    {
        //turn off cursor so you don't see it in screen and locks it in game window
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical");
        float straffe = Input.GetAxis("Horizontal");

        // keep movement smooth and in time with update
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        Vector3 movement = new Vector3(straffe, 0.0f, translation);
        if (movement.magnitude > 0) {
            movement = transform.TransformDirection(movement);
            rb.velocity = movement * speed;
            //rb.velocity = Vector3.RotateTowards(rb.velocity, transform.forward, transform.rotation.y * Mathf.Deg2Rad, speed);
            }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (((Input.GetKeyDown(KeyCode.Space)) && (jumpCounter <= 1)) || ((Input.GetKeyDown(KeyCode.Space)) && (jumpCounter <= 1) && (translation > 0)) || ((Input.GetKeyDown(KeyCode.Space)) && (jumpCounter <= 1) && (straffe > 0)))
        {
            rb.AddForce(0, 250, 0);
            jumpCounter++;
            if (jumpCounter >= 1)
            {
                jumpCounter = 0;
            }
        }
    }
}
