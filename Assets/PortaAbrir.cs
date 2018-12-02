using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbrir : MonoBehaviour {

    public Animator portaAnimator;
    public AudioSource portaAbrindoSom;
    private void Start()
    {
        portaAnimator.SetBool("Aberta", false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            portaAbrindoSom.Play();
            portaAnimator.SetBool("Aberta", true);
        }
    }
}
