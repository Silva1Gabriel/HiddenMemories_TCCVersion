using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour {
    public AudioClip[] footSteps;
    public AudioSource audioSource;
    

    // Esse código se baseia em basicamente usar uma lista de sons, onde um dos sons será sorteado que será acionado pelo evento da animação.

	void Awake () {
        audioSource = GetComponent<AudioSource>();
	}
	
    public void Step()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }
    public AudioClip GetRandomClip()
    {
        return footSteps[UnityEngine.Random.Range(0, footSteps.Length)];
    }


    void Update () {
		
	}
    
}
