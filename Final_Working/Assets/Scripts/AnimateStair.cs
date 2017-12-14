using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateStair : MonoBehaviour {

    Animator anim;
    float timer = 0f;
    int doneCount = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
            if ((timer >= 5f) && (doneCount < 1))//if enter has been more than 5 seconds
            {
                anim.enabled = true;
                doneCount++;
            }
                //Debug.Log("I've been hit!!");

        }
    }
}
