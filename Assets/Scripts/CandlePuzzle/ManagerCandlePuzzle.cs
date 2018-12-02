using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCandlePuzzle : MonoBehaviour
{
    public bool firstCandle = false;
    public bool secondCandle = false;
    public bool thirdCandle = false;

    public bool resultado = false;
    public bool reset = false;

    public bool puzzleCompletadoEItemPego=false;

    public GameObject chave;

    public GameObject chamaVela1;
    public GameObject chamaVela2;
    public GameObject chamaVela3;

    public bool chama1 = false;
    public bool chama2 = false;
    public bool chama3 = false;

    public GameObject somChama1;
    public GameObject somChama2;
    public GameObject somChama3;


    public GameObject triggersPosPorta;
    public KeyCollider kC;
    void Update()
    {
        reset = false;
        if (firstCandle == true && secondCandle == true && thirdCandle == true)
        {
            resultado = true;
            chave.SetActive(true);
            if(kC.keyPickedUp==true)
            {
                chave.SetActive(false);
                puzzleCompletadoEItemPego = true;
                triggersPosPorta.SetActive(true);

            }
        }
        if (chama1 == true && chama2 == true && chama3 == true && resultado == false)
        {
            StartCoroutine(DelayApagarVelas());
            chave.SetActive(false);   
        }
    }

    public void SequenciaErrada()
    {
        chamaVela1.SetActive(false);
        chamaVela2.SetActive(false);
        chamaVela3.SetActive(false);
        somChama1.SetActive(false);
        somChama2.SetActive(false);
        somChama3.SetActive(false);

        chama1 = false;
        chama2 = false;
        chama3 = false;
        firstCandle = false;
        secondCandle = false;
        thirdCandle = false;
        
       
    }
    public IEnumerator DelayApagarVelas()
    {
        yield return new WaitForSeconds(1);
        SequenciaErrada();
    }
}
