using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeEnemy : MonoBehaviour {
    public GameObject enemyMesh;
    public GameObject portal;
    public IA enemyScript;
    public Animator enemyAnimator;
    public AudioSource somMonstro;
    public AudioSource stepEnemySound;
    public bool entrou = false;
    public GameObject colliderCorreNao;
	
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player" && entrou==false)
        {
            
            somMonstro.Play();
            Invoke("Portal", 1);
            Invoke("Invocacao", 5);
            entrou = true;
            colliderCorreNao.SetActive(true);
        }
    }
    public void Invocacao()
    {
        enemyMesh.SetActive(true);
        enemyScript.isAware = true;
        enemyAnimator.SetBool("isWalking", true);
        enemyAnimator.SetBool("isRunning", true);
        stepEnemySound.loop = true;
        stepEnemySound.Play();
    }
    public void Portal()
    {
        portal.SetActive(true);
    }
}
