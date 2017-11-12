using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour {

    public static int TotalSphereCount = 0;

    public Transform[] TinySpherePrefabArray;
    public Transform[] SmallSpherePrefabArray;
    public Transform[] MediumSpherePrefabArray;
    public Transform[] LargeSpherePrefabArray;

    // on box collider trigger
    void OnTriggerEnter(Collider other) {
        Transform SpherePrefab;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                for (int k = 0; k < 22; k++)
                {
                    //5% large sphere -- [3]
                    //45% small sphere -- [1]
                    //20% medium sphere -- [2]
                    //30% tiny sphere -- [0]

                    if (Random.value <= 0.05f && Random.value >= 0f)
                    {
                        SpherePrefab = LargeSpherePrefabArray[Random.Range(0, 4)];
                    }
                    else if (Random.value <= 0.5f && Random.value > 0.05f)
                    {
                        SpherePrefab = SmallSpherePrefabArray[Random.Range(0, 4)];
                    }
                    else if (Random.value <= 0.7f && Random.value > 0.5f)
                    {
                        SpherePrefab = MediumSpherePrefabArray[Random.Range(0, 4)];
                    }
                    else
                    {
                        SpherePrefab = TinySpherePrefabArray[Random.Range(0, 4)];
                    }

                    Vector3 posxy = new Vector3(j - 15, 48 + i, k - 10);
                    Instantiate(SpherePrefab, posxy, Quaternion.identity);

                    TotalSphereCount++;
                }
            }
        }


        if (TotalSphereCount > 300)
        {
            Destroy(gameObject);
        }
    }
}
