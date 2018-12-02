using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraReturn : MonoBehaviour {
    public Transform player;
    public CinemachineVirtualCamera cameraPrePlaca;
    

    private void OnTriggerEnter(Collider other)
    {
        cameraPrePlaca.m_Priority = 20;
        cameraPrePlaca.m_Follow = player;
        cameraPrePlaca.m_LookAt = player;
    }
   
}
