using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareGenerator : MonoBehaviour
{

    public static int TotalSquareCount = 0;

    int hitCount = 0;

    public GameObject currentGO;
    public GameObject GO1;
    public GameObject GO2;
    public GameObject block;

    public Transform[] TinySquarePrefabArray;
    public Transform[] SmallSquarePrefabArray;
    public Transform[] MediumSquarePrefabArray;
    public Transform[] LargeSquarePrefabArray;

    // on box collider trigger
    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "TinySphereBullet(Clone)") && (hitCount < 1))
        {
            currentGO.SetActive(true);
            Transform SquarePrefab;
            GO1.SetActive(false);
            GO2.SetActive(false);
            block.SetActive(false);

            for (int i = 0; i < 12; i++) //y
            {
                for (int j = 0; j < 25; j++) //x
                {
                    for (int k = 0; k < 22; k++) //z
                    {
                        //5% large Square -- [3]
                        //45% small Square -- [1]
                        //20% medium Square -- [2]
                        //30% tiny Square -- [0]

                        if (Random.value <= 0.05f && Random.value >= 0f)
                        {
                            SquarePrefab = LargeSquarePrefabArray[Random.Range(0, 4)];
                        }
                        else if (Random.value <= 0.5f && Random.value > 0.05f)
                        {
                            SquarePrefab = SmallSquarePrefabArray[Random.Range(0, 4)];
                        }
                        else if (Random.value <= 0.7f && Random.value > 0.5f)
                        {
                            SquarePrefab = MediumSquarePrefabArray[Random.Range(0, 4)];
                        }
                        else
                        {
                            SquarePrefab = TinySquarePrefabArray[Random.Range(0, 4)];
                        }

                        Vector3 posxy = new Vector3(j - 12, 48 + i, k - 10);
                        Instantiate(SquarePrefab, posxy, Quaternion.identity);

                        TotalSquareCount++;
                    }
                }
            }


            if (TotalSquareCount > 300)
            {
                Destroy(gameObject);
            }
            hitCount++;
        }
    }
}
