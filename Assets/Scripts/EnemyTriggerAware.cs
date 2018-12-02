using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerAware : MonoBehaviour
{
    public GameObject portalSound;
    public GameObject monsterSound;
    public IA enemyScript;
    public GameObject enemy;
    public GameObject portal;
    public bool portalAtivo = false;

    
    public GameObject triggerEscadasSuperiores;
    public GameObject triggerMensagemExploracao;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //portalSound.SetActive(true);
            //portal.SetActive(true);
            //portalAtivo = true;
            
            triggerEscadasSuperiores.SetActive(true);
            triggerMensagemExploracao.SetActive(false);
        }
    }
    

    public IEnumerator EnemyTime()
    {

        yield return new WaitForSeconds(1.5f);
        enemyScript.isAware = true;
        enemy.SetActive(true);
        monsterSound.SetActive(true);
       

    }
    void Update()
    {
        if (portalAtivo == true)
        {
            StartCoroutine(EnemyTime());
           
        }
    }
    public void DesativarPortal()
    {
       // portal.SetActive(false);
    }
    
}
