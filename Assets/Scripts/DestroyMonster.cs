using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMonster : MonoBehaviour {

    public GameObject Enemy;
    public EnemyTriggerAware eTA;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            eTA.enabled = false;
            Enemy.SetActive(false);
        }
    }
}
