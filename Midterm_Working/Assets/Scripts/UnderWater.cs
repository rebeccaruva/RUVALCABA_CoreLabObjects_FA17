using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderWater : MonoBehaviour
{

    public float waterLevel;
    bool isUnderwater;
    Color normalColor;
    Color underwaterColor;
    Rigidbody rb;
    ConstantForce cf;
    CharacterController cc;
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;

    float posY;

    bool onCollision = true;
    bool jumping;


    // Use this for initialization
    void Start()
    {
        normalColor = new Color(0.89f, 0.93f, 1f, 0.5f);
        underwaterColor = new Color(0, 0.4f, 0.7f, 0.6f);

        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();
        fpc = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();

    }

    // Update is called once per frame
    void Update()
    {
        posY = transform.position.y;
        if (transform.position.y < waterLevel)
        {
            isUnderwater = transform.position.y < (waterLevel);
            if (isUnderwater)
            {
                SetUnderwater();
                //Debug.Log(isUnderwater); //true
            }
        } else
        {
            Debug.Log("I'm a normal polar bear");
            SetNormal();
        }
            //Debug.Log(posY);
    }

    //void SetSwim() {
    //    RenderSettings.fog = true;
    //    RenderSettings.fogColor = underwaterColor;
    //    RenderSettings.fogDensity = 0.04f;
    //    Debug.Log("I'm Normal!");

    //    rb.isKinematic = true;
    //    rb.useGravity = false;
    //    cf.enabled = false;

    //    fpc.m_WalkSpeed = 4f;
    //    fpc.m_RunSpeed = 7f;
    //    //fpc.m_StickToGroundForce = 10f;
    //    fpc.m_JumpSpeed = 8f;
    //    //fpc.m_GravityMultiplier = 2f;
    //}

        void SetNormal()
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = normalColor;
            RenderSettings.fogDensity = 0.008f;
            Debug.Log("I'm Normal!");


            rb.isKinematic = true;
            rb.useGravity = true;
            //cf.enabled = false;

            fpc.m_WalkSpeed = 4f;
            fpc.m_RunSpeed = 7f;
            fpc.m_StickToGroundForce = 10f;
            fpc.m_JumpSpeed = 8f;
            fpc.m_GravityMultiplier = 2f;
        }

        void SetUnderwater()
        {
            onCollision = false;
            RenderSettings.fog = true;
            RenderSettings.fogColor = underwaterColor;
            RenderSettings.fogDensity = 0.04f;


            rb.useGravity = true;
            rb.isKinematic = true;
            Debug.Log("I'm Underwater!");

            //cf.enabled = true;
            fpc.m_WalkSpeed = 2f;
            fpc.m_RunSpeed = 2.5f;
            fpc.m_StickToGroundForce = 0f;
            fpc.m_JumpSpeed = 3f;
            fpc.m_GravityMultiplier = .1f;
            jumping = false;

            if (Input.GetKeyDown(KeyCode.Space) && transform.position.y >= 0)
            {
                fpc.m_Jumping = false;
                fpc.m_Jump = false;
                rb.AddForce(transform.up * 50);
                fpc.m_JumpSpeed = 0f;
                fpc.m_GravityMultiplier = 0f;
                rb.useGravity = false;
                jumping = true;
                Debug.Log("I jump");
                fpc.m_AudioSource.clip = fpc.m_JumpSound;
                fpc.m_AudioSource.Play();
            }
            if (jumping)
            {
                fpc.m_Jumping = false;
                fpc.m_Jump = false;
                rb.AddForce(transform.up * 20);
                fpc.m_GravityMultiplier = 0f;
                rb.useGravity = false;
                jumping = true;
                rb.isKinematic = false;
                Debug.Log("jumping!");
            }
        
        //if (transform.position.y > (waterLevel - 3) && transform.position.y <= waterLevel)
        //{
        //    rb.isKinematic = false;
        //    rb.useGravity = false;
        //    //cf.enabled = false;

        //    fpc.m_WalkSpeed = 4f;
        //    fpc.m_RunSpeed = 7f;
        //    //fpc.m_StickToGroundForce = 10f;
        //    fpc.m_JumpSpeed = 8f;
        //    //fpc.m_GravityMultiplier = 2f;
        //}

        //fpc.m_Jump = false;
        //Debug.Log(transform.position.y);
        }

    //void OnCollisionEnter(Collision collision)
    //{
    //    onCollision = true;
    //}


    ////public void OnCollisionEnter(Collision collision)
    ////{
    ////    if (this.gameObject.name == "FPSController") return;
    ////    Debug.Log(collision.gameObject.name);
    ////    rb.isKinematic = true;
    ////    rb.useGravity = true;
    ////}

    //void OnCollisionExit(Collision collision)
    //{
    //    onCollision = false;
    //}
}
