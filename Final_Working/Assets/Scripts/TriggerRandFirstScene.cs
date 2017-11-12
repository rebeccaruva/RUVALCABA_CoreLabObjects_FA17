using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerRandFirstScene : MonoBehaviour {

    string[] sceneArray = { "FV Infinite", "FV Stairs" };
    //, "FV Void"

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

        SceneManager.LoadScene("FV Infinite");
    }
}
