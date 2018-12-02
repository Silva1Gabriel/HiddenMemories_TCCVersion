using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour {
    public AudioSource item;
    public ManagerCandlePuzzle mcp;
    public GameObject mensagemChave;
    public bool keyPickedUp=false;
     void OnTriggerStay(Collider other)
    {
      if(other.gameObject.tag=="Player" && mcp.resultado==true && Input.GetKeyDown(KeyCode.E))
        {
            item.Play();
            keyPickedUp = true;
           
            mensagemChave.SetActive(true);

        }
    }
}
