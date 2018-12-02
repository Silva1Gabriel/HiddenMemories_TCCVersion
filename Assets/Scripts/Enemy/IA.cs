using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA : MonoBehaviour
{

    public Animator anim;
    public GameObject cabeca;
    public GameObject cabecaAbaixada;
    public MoveCharacterTuca player;
    public ControleDoll CD;
    public float fov;
    public float viewDistance = 10f;
    public bool isAware = false;
    public AudioSource stepEnemySound;
    public NavMeshAgent agent;
    //public Renderer renderer;
    private EnemyPatrol ep;
    public LayerMask layer;
    public Light spot;
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        //renderer = GetComponent<Renderer>();
    }

    public void Update()
    {
        fov=spot.spotAngle ;
        viewDistance=spot.range;
        if (isAware)
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", true);
            agent.SetDestination(player.transform.position);
            //renderer.material.color = Color.red;
        }
        else
        {
           
            SearchForPlayer();
            //renderer.material.color = Color.blue;

        }
       
        
    }
    public void SearchForPlayer()
    {
        if (player.characterState1 != CharacterState1.crounching)
        {
            Debug.DrawLine(transform.position, cabeca.transform.position);
            if (Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(cabeca.transform.position)) < fov / 2f)
            {
                if (Vector3.Distance(cabeca.transform.position, transform.position) < viewDistance)
                {
                    Debug.DrawLine(transform.position, cabeca.transform.position, Color.red);
                    RaycastHit hit;
                    if (Physics.Linecast(transform.position, cabeca.transform.position, out hit, layer.value))
                    {

                        Debug.Log(hit.transform.tag);

                        if (hit.transform.tag == "Player" )
                        {
                            OnAware();
                            
                        }
                    }
                }
            }
        }
        if (player.characterState1 == CharacterState1.crounching)
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
                            OnAware();
                        }
                    }
                }
            }
        }
       
        
    }

    public void OnAware()
    {
        anim.SetBool("IsWalking", true);
        anim.SetBool("IsRunning", true);
        isAware = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", false);
            isAware = false;
            agent.speed = 0;
            CD.Morte();
            stepEnemySound.Stop();
            CD.enabled = true;

        }
    }

}
