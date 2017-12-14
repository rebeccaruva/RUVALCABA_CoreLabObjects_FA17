using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class washHands : MonoBehaviour
{

    public GameObject door;
    AudioSource hands;
    int count = 0;

    // Use this for initialization
    void Start()
    {
        hands = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (count < 3))
        {
            hands.Play();
            //Debug.Log("im here");
            door.SetActive(false);
            count++;
        }
    }
}
