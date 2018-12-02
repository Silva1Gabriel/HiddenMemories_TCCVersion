using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdquirido : MonoBehaviour {
    public bool itemPego = false;
    public GameObject backGround;
    public GameObject itemMacaneta;
    public GameObject triggerMensagem;
    public GameObject mensagemItem;
    public AudioSource itemSound;
     void OnTriggerStay(Collider other)
    {
        triggerMensagem.SetActive(true);
        backGround.SetActive(true);

        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && itemPego==false)
        {
            itemSound.Play();
            itemPego = true;
            itemMacaneta.SetActive(false);
            mensagemItem.SetActive(true);
            backGround.SetActive(false);

        }
        if(itemPego==true)
        {
            triggerMensagem.SetActive(false);
        }
      
    }

     void OnTriggerExit(Collider other)
    {
        triggerMensagem.SetActive(false);
    }
}
