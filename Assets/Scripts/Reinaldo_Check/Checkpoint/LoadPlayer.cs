﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("TucaCompleRBFinal (1)"))
        {
            transform.position = PlayerPrefsX.GetVector3("TucaCompleRBFinal (1)");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Save"))
        {
            PlayerPrefsX.SetVector3("TucaCompleRBFinal (1)", transform.position);
            PlayerPrefs.Save();

        }
    }
}
