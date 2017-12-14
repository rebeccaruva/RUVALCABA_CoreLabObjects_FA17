using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useBathroom : MonoBehaviour
{

    public GameObject sink;
    AudioSource toilet;
    int count = 0;

    // Use this for initialization
    void Start()
    {
        sink.SetActive(false);
        toilet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (count < 3))
        {
            toilet.Play();
            //Debug.Log("im here");
            sink.SetActive(true);
            count++;
        }
    }
}
