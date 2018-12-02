using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPorta : MonoBehaviour {
    public AudioSource somPorta;
    public GameObject mensagemPorta;
    public ItemAdquirido item;
    public Animation animPorta;
    public bool portaAberta=false;
     void OnTriggerStay(Collider other)
    {
        mensagemPorta.SetActive(true);
        if (other.gameObject.tag=="Player" && item.itemPego==true && Input.GetKeyDown(KeyCode.E) && portaAberta==false)
        {
            portaAberta =  true;
            somPorta.Play();
            animPorta.Play();
            mensagemPorta.SetActive(false);
            
        }
        if(portaAberta==true)
        {
            mensagemPorta.SetActive(false);
        }
     
    }
    public void OnTriggerExit(Collider other)
    {
        mensagemPorta.SetActive(false);
    }
}
