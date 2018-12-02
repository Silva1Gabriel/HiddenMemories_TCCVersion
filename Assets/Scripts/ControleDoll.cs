using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleDoll : MonoBehaviour
{

    public Rigidbody[] myRigidbodys;

    public MoveCharacterTuca MCT;
    public ControleDoll cD;
    public Animator playerAn;
    public GameObject canvasMorte;

    void Start()
    {
        myRigidbodys = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rdb in myRigidbodys)
        {
            rdb.isKinematic = true;
        }
    }
    public void Update()
    {
        
           
        
    }
    public void Morte()
    {
        foreach (Rigidbody rdb in myRigidbodys)
        {
            MCT.enabled = false;
            canvasMorte.SetActive(true);
            playerAn.enabled = false;
            rdb.isKinematic = false;
            Invoke("RestartScene", 8);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("Basement");
    }

}
