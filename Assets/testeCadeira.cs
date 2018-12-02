using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeCadeira : MonoBehaviour
{

    public Rigidbody cadeira;
    public GameObject personagem;
    public float forca;

    void Start()
    {
        cadeira.GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //cadeira.AddExplosionForce(forca, personagem.transform.position., 0f);
            cadeira.AddForce(personagem.transform.forward* forca);
        }
    }
}
