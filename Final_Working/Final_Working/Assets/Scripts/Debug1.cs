using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //string sceneToRun = sceneArray[Random.Range(0, sceneArray.Length - 1)];
        //SceneManager.LoadScene(sceneToRun);

        Debug.Log("I have been hit!!!");
    }
}
