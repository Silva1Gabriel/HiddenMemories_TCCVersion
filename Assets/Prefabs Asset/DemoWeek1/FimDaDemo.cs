using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimDaDemo : MonoBehaviour {
    public GameObject somJanela;
    public GameObject triggerInimigo;
    public ManagerCandlePuzzle puzzle;
   

    public bool triggered=false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player" && puzzle.puzzleCompletadoEItemPego==true )
        {   
            somJanela.SetActive(true);
            triggerInimigo.SetActive(true);
            Invoke("spawnInimigo", 2);
        }
    }
    public void spawnInimigo()
    {
        triggerInimigo.SetActive(true);
    }
}
