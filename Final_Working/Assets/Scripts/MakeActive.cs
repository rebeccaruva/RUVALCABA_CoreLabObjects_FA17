using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeActive : MonoBehaviour
{
    public GameObject activate;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "TinySphereBullet(Clone)")
        {
            activate.SetActive(true);
        }
    }
}
