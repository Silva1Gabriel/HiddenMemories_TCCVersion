using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockPick : MonoBehaviour {
    public GameObject lockPickObject;
    public PortaParaOSotao sotaoAcess;
    public GameObject mensagemLockPick;
    public AudioSource itemSound;
    
    
	// Use this for initialization
	void Start () {
        lockPickObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
       
		
	}

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && sotaoAcess.lockPick==false)
        {
            mensagemLockPick.SetActive(true);
            lockPickObject.SetActive(false);
            sotaoAcess.lockPick = true;
            itemSound.Play();
           
        }
    }
    
}
