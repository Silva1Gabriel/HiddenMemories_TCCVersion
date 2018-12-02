using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSwitch : MonoBehaviour
{

    //public Animator bridgeAnimator;

    //public GameObject bridgeCollider;
    public Animation doorAnimation;
    public bool isActive = false;
    public Light redLight;
    public Light greenLight;

    public GameObject textodeInteracao;
    public GameObject textodeInteracao2;

    //material 

    public Animator Macaneta;
    public Material[] material;

    Renderer rend;

    public AudioSource somPonte;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnTriggerStay(Collider other)
    {


        if (isActive == false)
        {
            textodeInteracao.SetActive(true);
            textodeInteracao2.SetActive(true);

            Debug.Log(other.gameObject.tag);
            if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && isActive == false)

            {
                redLight.enabled = false;
                greenLight.enabled = true;
                //rend.sharedMaterial = material[1];
                BridgeActive();

                //bridgeAnimator.SetBool("OpenBridge", true);


                StartCoroutine(delayAnimation());
            }
        }
        if (isActive == true)
        {
            textodeInteracao2.SetActive(false);
        }

    }
    void OnTriggerExit(Collider other)
    {

        textodeInteracao.SetActive(false);

    }

    private IEnumerator delayAnimation()
    {
        yield return new WaitForSeconds(1);
        doorAnimation.Play();
        somPonte.Play();

    }
    public void BridgeActive()
    {
        isActive = true;
        textodeInteracao.SetActive(false);
    }
}
