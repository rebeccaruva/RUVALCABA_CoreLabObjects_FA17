using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflecctProbeController : MonoBehaviour {

	public enum Directions { X, Y, Z };
    public Directions orientation;
    public GameObject mirror;
    public GameObject character;

    float offset;
    Vector3 probePos;

	// Update is called once per frame
	void Update () {
		if (orientation == Directions.X)
        {
            offset = mirror.transform.position.x - character.transform.position.x;
            probePos.x = mirror.transform.position.x + offset;
            probePos.y = character.transform.position.y;
            probePos.z = character.transform.position.z;
        }
        if (orientation == Directions.Y)
        {
            offset = mirror.transform.position.y - character.transform.position.y;
            probePos.x = character.transform.position.x;
            probePos.y = mirror.transform.position.y + offset;
            probePos.z = character.transform.position.z;
        }
        if (orientation == Directions.Z)
        {
            offset = mirror.transform.position.z - character.transform.position.z;
            probePos.x = character.transform.position.x;
            probePos.y = character.transform.position.y;
            probePos.z = mirror.transform.position.z + offset;
        }

        transform.position = probePos;

    }
}
