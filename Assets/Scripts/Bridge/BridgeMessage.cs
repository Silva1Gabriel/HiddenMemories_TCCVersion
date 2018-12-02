using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMessage : MonoBehaviour
{
   
    public GameObject bridgeMessage;
    public BridgeSwitch bS;
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && bS.isActive == false)
        {
            bridgeMessage.SetActive(true);
        }
       
    }
     void OnTriggerExit(Collider other)
    {
        bridgeMessage.SetActive(false);
    }
}
