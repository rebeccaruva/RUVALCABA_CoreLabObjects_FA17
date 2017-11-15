using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 250f;
    Rigidbody rb;

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

        rb.velocity = (movement * speed);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
