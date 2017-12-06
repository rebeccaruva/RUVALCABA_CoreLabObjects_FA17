using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateSami : MonoBehaviour {

    Animator anim;

    bool isWalking = false;

    const int idleState = 0;
    const int walkState = 1;

    int currentState = idleState;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        if ((Input.GetKey(KeyCode.DownArrow)) || 
            (Input.GetKey(KeyCode.UpArrow)) || 
            (Input.GetKey(KeyCode.LeftArrow)) || 
            (Input.GetKey(KeyCode.RightArrow))
            ) {
            ChangeState(walkState);
        } else {
            ChangeState(idleState);
        }
    }

    void ChangeState(int state)
    {
        if (currentState == state)
        {
            return;
        }
        switch (state)
        {
            case walkState:
                anim.SetInteger("state", walkState);
                break;

            case idleState:
                anim.SetInteger("state", idleState);
                break;
        }
        currentState = state;
    }

}
