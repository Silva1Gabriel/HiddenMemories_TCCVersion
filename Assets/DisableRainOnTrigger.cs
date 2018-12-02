using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRainOnTrigger : MonoBehaviour {
    public GameObject chuvaMae;
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            chuvaMae.SetActive(false);
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            chuvaMae.SetActive(true);
        }
    }
}
