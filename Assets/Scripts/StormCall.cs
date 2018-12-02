using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormCall : MonoBehaviour
{
    public AudioSource Thunder;
    public AudioSource ChuvaSound;
    public GameObject ChuvaParticle;
    public bool triggerAtivo = false;
    public Animation chuvaAnim;
    public GameObject Triggerchuva;

    void Update()
    {
        if (triggerAtivo == true)
        {
            AtivarThunder();
            Invoke("AtivarSomChuva", 7);
            Invoke("AtivarParticulas", 9);
            triggerAtivo = false;
            Triggerchuva.SetActive(false);

        }   
    }
   
    public void AtivarThunder()
    {
        Thunder.Play();
    }
    public void AtivarSomChuva()
    {
        chuvaAnim.Play();
        ChuvaSound.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            triggerAtivo = true;
        }
    }
    public void AtivarParticulas()
    {
        ChuvaParticle.SetActive(true);
    }
}
