using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateStair : MonoBehaviour {

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
                anim.enabled = true;
                Debug.Log("I've been hit!!");

        }
    }
}
