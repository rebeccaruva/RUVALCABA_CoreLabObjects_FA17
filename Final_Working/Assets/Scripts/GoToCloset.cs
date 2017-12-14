using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCloset : MonoBehaviour
{

    public GameObject door;
    AudioSource shoes;
    int count = 0;

    // Use this for initialization
    void Start()
    {
        shoes = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (count < 1))
        {
            shoes.Play();
            //Debug.Log("im here");
            door.SetActive(false);
            count++;
        }
    }
}
