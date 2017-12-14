using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLight : MonoBehaviour {

    public GameObject lightz;
    int hit;

	// Use this for initialization
	void Start () {
        lightz.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "TinySphereBullet(Clone)") && (hit < 1))
        {
            lightz.SetActive(true);
            hit++;
        }
    }
}
