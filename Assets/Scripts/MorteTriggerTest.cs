using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteTriggerTest : MonoBehaviour {

    public ScriptPersonagem SP;
    public ControleDoll cD;
    public Animator playerAn;
    public CharacterController CC;

	void Start () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
           
            cD.Morte();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
