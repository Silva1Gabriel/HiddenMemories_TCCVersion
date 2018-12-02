using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAttic : MonoBehaviour {
    public GameObject mensagemChaveAttic;
    public GameObject chaveAtticObject;
    public AudioSource item;
    public GameObject TriggerPorão;
    public GameObject messageTriggerPorao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            item.Play();
            chaveAtticObject.SetActive(false);
            mensagemChaveAttic.SetActive(true);
            TriggerPorão.SetActive(true);
            messageTriggerPorao.SetActive(false);
        }
    }

}
