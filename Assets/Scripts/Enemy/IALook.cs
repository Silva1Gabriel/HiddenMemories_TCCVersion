using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IALook : MonoBehaviour
{
   
   // public GameObject origem;
    public IALook iaL;
    public GameObject cabeca;
    public GameObject cabecaAbaixada;
    public Transform target;
    public Transform targetPlayer;
    public bool isSpoted = false;
    public Renderer renderer;
    public float viewDistance = 10f;
    public float fov;
    public Light spot;
    public LayerMask layer;

    public ControlePersonagem player;
    public Animator playerAnim;
    public ControleDoll CD;
    public GameObject Raio;

    void FixedUpdate()
    {
        Vector3.Distance(player.transform.position, this.transform.position);
        fov = spot.spotAngle;
        viewDistance = spot.range;
        if ( isSpoted&& Vector3.Distance(player.transform.position, this.transform.position) < viewDistance && Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(cabeca.transform.position)) < fov / 2f)
        {
            Debug.Log(gameObject.name);
            renderer.material.color = Color.red;
            transform.LookAt(targetPlayer);
            Raio.SetActive(true);
            //playerAnim.enabled = false;
           // player.enabled = false;
            CD.Morte();
            
        }
        else
        {
            isSpoted = false;
            
            SearchForPlayerWithoutChase();
            renderer.material.color = Color.blue;
            transform.LookAt(target);

        }
    }
   
    public void SearchForPlayerWithoutChase()
    {
      
        
        if (player.characterState == CharacterState.crounching || player.characterState == CharacterState.walking || player.characterState == CharacterState.idle || player.characterState == CharacterState.running)
        {
            Debug.DrawLine(transform.position, cabecaAbaixada.transform.position);
            if (Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(cabecaAbaixada.transform.position)) < fov / 2f)
            {
                if (Vector3.Distance(cabecaAbaixada.transform.position, transform.position) < viewDistance)
                {
                    Debug.DrawLine(transform.position, cabecaAbaixada.transform.position, Color.red);
                    RaycastHit hit;
                    if (Physics.Linecast(transform.position, cabecaAbaixada.transform.position, out hit, layer.value))
                    {
                        Debug.Log(hit.transform.tag);

                        if (hit.transform.tag == "Player")
                        {
                            OnSpoted();
                        }
                    }
                }
                else
                {
                    isSpoted = false;
                }
            }
        }


    }
    public void OnSpoted()
    {
        isSpoted = true;
    }


}
