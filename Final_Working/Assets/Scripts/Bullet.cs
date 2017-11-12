using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //Get access to the prefab
    public GameObject bullet;

    //... to the PosReference
    public Transform PosReference;

    AudioSource bulletSound;

    // Use this for initialization
    void Start()
    {
        bulletSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //instantiate bullet prefab
            //Instantiate: three perameters
            //1. prefab
            //2. starting position
            //3. starting rotation
            Instantiate(bullet, PosReference.position, PosReference.rotation);
            bulletSound.Play();
        }
    }
}
