using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPoraoLoading : MonoBehaviour {
    public GameObject FadeOutToLoadingPorao;
    // Use this for initialization
    public bool fadeAtivo = false;
    public Animator animPlayer;
    public MoveCharacterTuca MTC;

    public void Update()
    {
        if(fadeAtivo==true)
        {
            StartCoroutine(Delay());
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            FadeOutToLoadingPorao.SetActive(true);
            fadeAtivo = true;
            animPlayer.enabled = false;
            MTC.enabled = false;
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("LoadingPorao");
    }
 }
