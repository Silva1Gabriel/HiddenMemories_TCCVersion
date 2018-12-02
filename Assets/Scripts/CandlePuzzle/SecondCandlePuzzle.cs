using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCandlePuzzle : MonoBehaviour
{

    public ManagerCandlePuzzle mcp;
    // Use this for initialization
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            //spawParticle
            mcp.chamaVela2.SetActive(true);
            mcp.chama2 = true;
            mcp.somChama2.SetActive(true);
            if (mcp.firstCandle == true && mcp.thirdCandle == false)
            {

                mcp.secondCandle = true;

            }
           
        }
       
        
    }
}
