using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEletrica : MonoBehaviour
{
    public Animator tranca;
    public Material[] material;

    Renderer rend;

    void Start()
    {

        tranca.GetComponent<Animator>();

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rend.sharedMaterial = material[0];
        }


        else if (Input.GetKeyDown(KeyCode.T))
        {
            rend.sharedMaterial = material[1];
        }


        else if (Input.GetKeyDown(KeyCode.U))
        {
            rend.sharedMaterial = material[2];
            tranca.SetBool("Open", true);
        }
    }
}
