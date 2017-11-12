using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairHitColor : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    int hitCount = 0;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}
	

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "Player") && (hitCount == 0))
        {
            rend.sharedMaterial = material[1];
            hitCount++;
        } else
        {
            rend.sharedMaterial = material[2];
        }
    }
}
