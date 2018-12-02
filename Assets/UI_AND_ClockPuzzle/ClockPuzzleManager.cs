using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ClockPuzzleManager : MonoBehaviour
{
    public Transform ponteiroHoras;
    public Transform ponteiroMinutos;

    public Transform rotacaoTresHoras;
    public Transform rotacaoSeisHoras;
    public Transform rotacaoNoveHoras;
    public Transform rotacaoDozeHoras;

    public Transform rotacaoZeroMinutos;
    public Transform rotacaoQuinzeMinutos;
    public Transform rotacaoTrintaMinutos;
    public Transform rotacaoQuarentaECincoMinutos;

    public bool horas = false;
    public bool posicaoHoras1 = false;
    public bool posicaoHoras2 = false;
    public bool posicaoHoras3 = false;
    public bool posicaoHoras4 = false;

    public bool minutos = false;
    public bool posicaoMinutos1 = false;
    public bool posicaoMinutos2 = false;
    public bool posicaoMinutos3 = false;
    public bool posicaoMinutos4 = false;

    public bool rightArrowPressed = false;
    public bool leftArrowPressed = false;

    public bool puzzleComplete = false;
    public bool puzzleActive = false;
    public GameObject trigger;
    public GameObject UI_TIPS;
    public GameObject UI_Pause;
    public AudioSource TickTack;
    public PauseScript PS;

    public float delay=1f;

    public Animator animClock;
    // TUCA
    public Animator anim;
    public MoveCharacterTuca player;

    // CAMERA
    public CinemachineVirtualCamera CVC1;
    public CinemachineVirtualCamera CVC2;


    // Use this for initialization
    void Start()
    {
        horas = true;
        minutos = false;
        posicaoHoras1 = true;
        posicaoMinutos1 = true;
        ponteiroHoras.transform.rotation = rotacaoDozeHoras.transform.rotation;
        ponteiroMinutos.transform.rotation = rotacaoZeroMinutos.transform.rotation;
        animClock.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PonteiroHorasEMinutos();
        Switch();
        PuzzleComplete();
    }
    public void PonteiroHorasEMinutos()
    {
        if (puzzleActive == true)
        {
            if (horas == true)
            {
                if (ponteiroHoras.transform.rotation == rotacaoDozeHoras.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoHoras1 == true && rightArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoTresHoras.transform.rotation;
                        posicaoHoras1 = false;
                        posicaoHoras2 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H",true);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);


                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoHoras1 == true && leftArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoNoveHoras.transform.rotation;
                        posicaoHoras1 = false;
                        posicaoHoras4 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", true);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);

                    }


                }

                if (ponteiroHoras.transform.rotation == rotacaoTresHoras.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoHoras2 == true && rightArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoSeisHoras.transform.rotation;
                        posicaoHoras2 = false;
                        posicaoHoras3 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", true);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);


                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoHoras2 == true && leftArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoDozeHoras.transform.rotation;
                        posicaoHoras2 = false;
                        posicaoHoras1 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", true);
                    }

                }

                if (ponteiroHoras.transform.rotation == rotacaoSeisHoras.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoHoras3 == true && rightArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoNoveHoras.transform.rotation;
                        posicaoHoras3 = false;
                        posicaoHoras4 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", true);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);

                    }
                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoHoras3 == true && leftArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoTresHoras.transform.rotation;
                        posicaoHoras3 = false;
                        posicaoHoras2 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();

                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", true);
                        animClock.SetBool("3H_12H", false);
                    }

                }
                if (ponteiroHoras.transform.rotation == rotacaoNoveHoras.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoHoras4 == true && rightArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoDozeHoras.transform.rotation;
                        posicaoHoras4 = false;
                        posicaoHoras1 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", true);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", false);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);

                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoHoras4 == true && leftArrowPressed == false)
                    {
                        ponteiroHoras.transform.rotation = rotacaoSeisHoras.transform.rotation;
                        posicaoHoras4 = false;
                        posicaoHoras3 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();
                        animClock.SetBool("12H", false);
                        animClock.SetBool("12H_3H", false);
                        animClock.SetBool("3H_6H", false);
                        animClock.SetBool("6H_9H", false);
                        animClock.SetBool("9H_12H", false);
                        animClock.SetBool("12H_9H", false);
                        animClock.SetBool("9H_6H", true);
                        animClock.SetBool("6H_3H", false);
                        animClock.SetBool("3H_12H", false);
                    }

                }


            }
            if (minutos == true)
            {
                if (ponteiroMinutos.transform.rotation == rotacaoZeroMinutos.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoMinutos1 == true && rightArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoQuinzeMinutos.transform.rotation;
                        posicaoMinutos1 = false;
                        posicaoMinutos2 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();


                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoMinutos1 == true && leftArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoQuarentaECincoMinutos.transform.rotation;
                        posicaoMinutos1 = false;
                        posicaoMinutos4 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();

                    }


                }

                if (ponteiroMinutos.transform.rotation == rotacaoQuinzeMinutos.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoMinutos2 == true && rightArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoTrintaMinutos.transform.rotation;
                        posicaoMinutos2 = false;
                        posicaoMinutos3 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();


                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoMinutos2 == true && leftArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoZeroMinutos.transform.rotation;
                        posicaoMinutos2 = false;
                        posicaoMinutos1 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();

                    }

                }

                if (ponteiroMinutos.transform.rotation == rotacaoTrintaMinutos.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoMinutos3 == true && rightArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoQuarentaECincoMinutos.transform.rotation;
                        posicaoMinutos3 = false;
                        posicaoMinutos4 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();


                    }
                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoMinutos3 == true && leftArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoQuinzeMinutos.transform.rotation;
                        posicaoMinutos3 = false;
                        posicaoMinutos2 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();

                    }

                }
                if (ponteiroMinutos.transform.rotation == rotacaoQuarentaECincoMinutos.transform.rotation)
                {

                    if (Input.GetKey(KeyCode.RightArrow) && posicaoMinutos4 == true && rightArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoZeroMinutos.transform.rotation;
                        posicaoMinutos4 = false;
                        posicaoMinutos1 = true;
                        rightArrowPressed = true;
                        Invoke("DelayRightArrow", delay);
                        TickTack.Play();


                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && posicaoMinutos4 == true && leftArrowPressed == false)
                    {
                        ponteiroMinutos.transform.rotation = rotacaoTrintaMinutos.transform.rotation;
                        posicaoMinutos4 = false;
                        posicaoMinutos3 = true;
                        leftArrowPressed = true;
                        Invoke("DelayLeftArrow", delay);
                        TickTack.Play();

                    }

                }


            }


        }
    }
    public void DelayRightArrow()
    {
        rightArrowPressed = false;
    }
    public void DelayLeftArrow()
    {
        leftArrowPressed = false;
    }
    public void Switch()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            horas = false;
            minutos = true;
            
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            horas = true;
            minutos = false;
        }

    }
    public void PuzzleComplete()
    {
        if(posicaoHoras3==true && posicaoMinutos4==true)
        {
            puzzleComplete = true;
            trigger.SetActive(false);
            UI_TIPS.SetActive(false);
            anim.enabled = true;
            player.enabled = true;
            puzzleActive = false;
            CVC1.m_Priority = 10;
            CVC2.m_Priority = 0;


        }
    }
    public void OnTriggerStay(Collider other)
    {
        PS.enabled = false;
        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            UI_TIPS.SetActive(true);
            anim.enabled = false;
            player.enabled = false;
            puzzleActive = true;
            CVC2.m_Priority = 20;
            CVC1.m_Priority = 0;
            //UI_Pause.SetActive(false);
            

        }
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Escape))
        {
            UI_TIPS.SetActive(false);
            anim.enabled = true;
            player.enabled = true;
            puzzleActive = false;
            CVC1.m_Priority = 10;
            CVC2.m_Priority = 0;
            //UI_Pause.SetActive(true);
            
        }
        else
        {
            PS.enabled = true;
        }
    }
    
}
