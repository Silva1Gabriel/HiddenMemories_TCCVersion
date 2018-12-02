using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoFakeSusto : MonoBehaviour {

    public GameObject InimigoEFumaca;
    public AudioSource EnemySound;
    public bool on = false;

    public void Update()
    {
        if(on==true)
        {
            StartCoroutine(TimeToDisapear());
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && on==false)
        {
            on = true;
            EnemySound.Play();
        }
    }
    private IEnumerator TimeToDisapear()
    {
         yield return new WaitForSeconds(2);
        InimigoEFumaca.SetActive(false);
    }
}
