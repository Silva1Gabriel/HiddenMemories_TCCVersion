using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessagensFixas : MonoBehaviour
{
    public AudioSource doorClosedSound;
    public AudioSource doorUnlockSound;
    public ItemAdquirido macaneta;
    public GameObject Text;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && macaneta.itemPego==false)
        {
            doorClosedSound.Play();
            Text.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && macaneta.itemPego == false)
        {
            doorUnlockSound.Play();
            Text.SetActive(false);

        }
    }

    void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }


}
