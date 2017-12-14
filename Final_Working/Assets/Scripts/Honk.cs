using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honk : MonoBehaviour
{

    AudioSource honk;

    // Use this for initialization
    void Start()
    {
        honk = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            honk.Play();
            //Debug.Log("im here");
        }
    }
}
