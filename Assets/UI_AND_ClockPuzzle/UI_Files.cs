﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Files : MonoBehaviour
{
    public PauseScript PS;
    public GameObject Text1;
    public bool aberto = false;
    public GameObject fileOpenSound;
    public GameObject fileCloseSound;


    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player"  )
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                aberto = true;
                PS.enabled = false;
                Text1.SetActive(true);
                Time.timeScale = 0f;
                fileOpenSound.SetActive(true);
                fileCloseSound.SetActive(false);

            }

            

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                
            }
        }
       

    }
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && aberto==true)
        {
            PS.enabled = true;
            Text1.SetActive(false);
            Time.timeScale = 1f;
            fileOpenSound.SetActive(false);
            fileCloseSound.SetActive(true);
            aberto = false;
        }
        
    }
}
