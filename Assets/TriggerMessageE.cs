using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessageE : MonoBehaviour {
    public GameObject message;

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            message.SetActive(true);
        }
       
    }
    public void OnTriggerExit(Collider other)
    {
        message.SetActive(false);
    }
}
