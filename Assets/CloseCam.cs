using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCam : MonoBehaviour
{

    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            cam1.Priority = 10;
            cam2.Priority = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            cam1.Priority = 0;
        }
    }
}
