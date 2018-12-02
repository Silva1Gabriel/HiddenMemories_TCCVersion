using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour {
    public Transform player;
    public CinemachineFreeLook cameraSecundaria;
    public CinemachineVirtualCamera cameraPrincipal;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cameraSecundaria.enabled = true;
            cameraPrincipal.enabled = false;
            // cameraPlaca.m_Priority = 20;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        cameraSecundaria.enabled = false;
        cameraPrincipal.enabled = true;
    }

}
