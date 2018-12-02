using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessage : MonoBehaviour
{

    public GameObject Text;

    void OnTriggerStay(Collider other)
    {
        Text.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }


}
