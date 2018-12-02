using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaTrancada : MonoBehaviour {
    public AudioSource portaTrancada;
     void OnTriggerStay(Collider other)
    {
      if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            portaTrancada.Play();
        }
    }
}
