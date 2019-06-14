﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
   // Animator anim;

    // Use this for initialization
    void Start()
    {
      //  anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoorOpens()
    {
        Destroy(this.gameObject);
    }

    public void DoorCloses()
    {
        //anim.SetBool("Opens", false);
    }

    void CollEnable()
    {
        GetComponent<Collider2D>().enabled = true;
    }

    void CollDisable()
    {
        GetComponent<Collider2D>().enabled = false;
    }



}
