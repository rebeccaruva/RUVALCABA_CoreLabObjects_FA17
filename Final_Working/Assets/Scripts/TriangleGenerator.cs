using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleGenerator : MonoBehaviour
{

    public static int TotalTriangleCount = 0;

    int hitCount = 0;

    public GameObject currentGO;
    public GameObject GO1;
    public GameObject GO2;
    public GameObject block;

    public Transform[] TinyTrianglePrefabArray;
    public Transform[] SmallTrianglePrefabArray;
    public Transform[] MediumTrianglePrefabArray;
    public Transform[] LargeTrianglePrefabArray;

    // on box collider trigger
    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "TinySphereBullet(Clone)") && (hitCount < 1))
        {
            currentGO.SetActive(true);
            Transform TrianglePrefab;
            GO1.SetActive(false);
            GO2.SetActive(false);
            block.SetActive(false);

            for (int i = 0; i < 12; i++) //y
            {
                for (int j = 0; j < 25; j++) //x
                {
                    for (int k = 0; k < 22; k++) //z
                    {
                        //5% large Triangle -- [3]
                        //45% small Triangle -- [1]
                        //20% medium Triangle -- [2]
                        //30% tiny Triangle -- [0]

                        if (Random.value <= 0.05f && Random.value >= 0f)
                        {
                            TrianglePrefab = LargeTrianglePrefabArray[Random.Range(0, 4)];
                        }
                        else if (Random.value <= 0.5f && Random.value > 0.05f)
                        {
                            TrianglePrefab = SmallTrianglePrefabArray[Random.Range(0, 4)];
                        }
                        else if (Random.value <= 0.7f && Random.value > 0.5f)
                        {
                            TrianglePrefab = MediumTrianglePrefabArray[Random.Range(0, 4)];
                        }
                        else
                        {
                            TrianglePrefab = TinyTrianglePrefabArray[Random.Range(0, 4)];
                        }

                        Vector3 posxy = new Vector3(j - 12, 48 + i, k - 10);
                        Instantiate(TrianglePrefab, posxy, Quaternion.identity);

                        TotalTriangleCount++;
                    }
                }
            }


            if (TotalTriangleCount > 300)
            {
                Destroy(gameObject);
            }
            hitCount++;
        }
    }
}
