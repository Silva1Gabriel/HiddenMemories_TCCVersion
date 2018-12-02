using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerPorta : MonoBehaviour
{
    public Animator anim;
    public MoveCharacterTuca MCT;
    public GameObject FadeOut;
    public bool fadeAtivo = false;
    public GameObject SomPorta;
    public GameObject MensagemInteragir;

    void OnTriggerStay(Collider other)
    {
        MensagemInteragir.SetActive(true);
        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            MCT.enabled = false;
            anim.enabled = false;
            FadeOut.SetActive(true);
            SomPorta.SetActive(true);
           
            fadeAtivo = true;
        }
    }
    public void Update()
    {
        if(fadeAtivo==true)
        {
            StartCoroutine(DelayChangeLevel());
        }
    }
    public IEnumerator DelayChangeLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LoadingNewGroundFloor");
    }
}
