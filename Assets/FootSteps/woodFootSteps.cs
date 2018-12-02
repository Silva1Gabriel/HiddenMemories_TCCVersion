using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodFootSteps : MonoBehaviour {
    public AudioClip[] woodFootSounds;
    public FootSteps FSP;
	

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            FSP.footSteps = woodFootSounds;
        }
    }
    
}
