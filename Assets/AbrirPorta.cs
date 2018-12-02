using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AbrirPorta : MonoBehaviour {
    public AudioSource somPorta;
    public Animation animPorta;
    public bool portaAberta = false;
     void OnTriggerStay(Collider other)
    {
     if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && portaAberta==false)
        {
            somPorta.Play();
            animPorta.Play();
            portaAberta = true;
        }
    }
    
}
