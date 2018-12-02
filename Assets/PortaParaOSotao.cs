using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaParaOSotao : MonoBehaviour
{
    public GameObject mensagemPortaTrancada;
    
    public AudioSource trancada;
    public GameObject TriggerEscada;
    public bool lockPick = false;

    // Use this for initialization
    void Start()
    {
        TriggerEscada.SetActive(false);
    }

     void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && lockPick==false)
        {
            mensagemPortaTrancada.SetActive(true);
            trancada.Play();
        }

        if (lockPick == true && Input.GetKeyDown(KeyCode.E))
        {
            TriggerEscada.SetActive(true);
        }
       
    }
     void OnTriggerExit(Collider other)
    {
        mensagemPortaTrancada.SetActive(false);
    }
}
