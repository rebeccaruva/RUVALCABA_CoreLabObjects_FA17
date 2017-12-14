using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour {

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 1.0f;
    public float smoothing = 2.0f;
    float rotX, rotY;

    GameObject character;

	// Use this for initialization
	void Start () {
        character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        rotX = mouseLook.x;
        rotY = mouseLook.y;

        //Debug.Log("before: " + rotY);
        //Mathf.Clamp(rotY, -5, 5);
        //Debug.Log("after: " + rotY);

        if (rotY <= -75f)
        {
            rotY = -75f;
        }
        else if (rotY >= 75f)
        {
            rotY = 75f;
        }

        transform.localRotation = Quaternion.AngleAxis(-rotY, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(rotX, character.transform.up);

    }
}
