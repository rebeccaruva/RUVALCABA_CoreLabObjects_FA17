using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour {
    Rigidbody rb;
    
    void Start()
    {

        rb = GameObject.Find("FPSController").gameObject.GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (this.gameObject.name == "FPSController") return;
        Debug.Log(col.gameObject.name);
        rb.isKinematic = true;
        rb.useGravity = true;
    }
}
