using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandTarget : MonoBehaviour {

    public Transform[] TargetPrefabArray;
    //public Transform[] TargetPosArray;
    int randomNum;
    Transform targetPrefab;
    //Transform targetPos;


    // Use this for initialization
    void Start () {
        randomNum = Random.Range(0, 3);
        targetPrefab = TargetPrefabArray[randomNum];
        //targetPos = TargetPosArray[randomNum];
        Vector3 posxy = new Vector3(0f, 56f, 29.7f);
        Instantiate(targetPrefab, posxy, Quaternion.Euler(new Vector3(90, 0, 0)));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
