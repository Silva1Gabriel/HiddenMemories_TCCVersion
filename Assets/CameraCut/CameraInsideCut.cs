using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraInsideCut : MonoBehaviour
{

    public CinemachineVirtualCamera camera;


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera.m_Priority = 10;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        
            camera.m_Priority = 0;
        
    }
}
