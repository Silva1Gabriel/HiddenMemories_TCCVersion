using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDaDemoOficial : MonoBehaviour {

    public IA ia;
    public GameObject canvasFadeOut;
    public InvokeEnemy iE;
    public AudioSource stepEnemySound;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Time.timeScale = 0f;
            canvasFadeOut.SetActive(true);
            iE.stepEnemySound.Stop();
            DelayCredito();
        }
    }

    public void DelayCredito()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1f;
    }
}
