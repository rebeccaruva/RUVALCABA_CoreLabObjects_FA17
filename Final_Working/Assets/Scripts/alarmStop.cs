using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmStop : MonoBehaviour {

    public GameObject sami;
    public GameObject door;
    AudioSource alarm;

	// Use this for initialization
	void Start () {
        alarm = sami.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            alarm.Stop();
            //Debug.Log("im here");
            door.SetActive(false);
        }
    }
}
