﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassFootSteps : MonoBehaviour {
    public AudioClip[] grassFootSounds;
    public FootSteps FSP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            FSP.footSteps = grassFootSounds;
        }
    }
    
}
