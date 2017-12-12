using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class SpaceBarEffects : MonoBehaviour
{

    public PostProcessingProfile ppBloom;
    public PostProcessingProfile ppBloomExtra;
    PostProcessingProfile ppp;
    float timer = 0;
    bool bloomExtra = false;

    void Start()
    {
        ppp = GetComponent<PostProcessingBehaviour>().profile = ppBloom;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Input.GetKeyDown(KeyCode.Space))
        {
            bloomExtra = true;            
        }

        if (bloomExtra) {
            ppp = GetComponent<PostProcessingBehaviour>().profile = ppBloomExtra;
            if (timer>1.5f) {
                ppp = GetComponent<PostProcessingBehaviour>().profile = ppBloom;
                timer = 0;
                bloomExtra = false;
            }
            timer += Time.deltaTime;
        }

        
    }

  }
