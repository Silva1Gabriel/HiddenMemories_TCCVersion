using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOptions : MonoBehaviour
{ // sistema criado para esconder as qualidades.


    public AudioSource click;   
    public GameObject optionsQ;
    public GameObject setinhaQ; 
    public GameObject setinhaDisableQ;


    void Start()
    {
        optionsQ.SetActive(false);
        

        setinhaQ.SetActive(true);
        
        setinhaDisableQ.SetActive(false);
        
    }

   
    public void EnableOptionsQ()
    {
        optionsQ.SetActive(true);
        click.Play();
        setinhaQ.SetActive(false);
        setinhaDisableQ.SetActive(true);


    }
    public void DisableOptionsQ()
    {

        optionsQ.SetActive(false);
        click.Play();
        setinhaQ.SetActive(true);
        setinhaDisableQ.SetActive(false);

    }
}
