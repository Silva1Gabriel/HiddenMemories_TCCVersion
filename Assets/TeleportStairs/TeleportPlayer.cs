using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

    public GameObject newPos;
    public GameObject playerPos;

    public MoveCharacterTuca MCT;
    public Animator anim;
    public bool teleport = false;
    public bool pause = false;
   
    public Animation fadeAnim;
    public AudioSource stairsSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (teleport == true)
        {
            StartCoroutine(teleportTimer());
            StartCoroutine(UnPause());
            StartCoroutine(soundSteps());
            
           
        }
	}
     void OnTriggerStay(Collider other)
    {
     if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
           
            teleport =true;
            fadeAnim.Play();
            MCT.enabled = false;
            anim.enabled = false;
            soundSteps();

        }
    }

    private IEnumerator UnPause()
    {
        yield return new WaitForSeconds(7);
        MCT.enabled = true;
        anim.enabled = true;
        //stairsSound.Stop();
        

    }
    private IEnumerator teleportTimer()
    {
        yield return new WaitForSeconds(4);
        playerPos.transform.position = newPos.transform.position;
        teleport = false;
        

    }
    
    private IEnumerator soundSteps()
    {
        yield return new WaitForSeconds(0.5f);
        stairsSound.Play();
    }
}
