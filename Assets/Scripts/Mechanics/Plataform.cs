using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{

    public GameObject startPos;
    public GameObject endPos;
    public float tempo = 1;

    // Use this for initialization
    void Start()
    {
        transform.position = startPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, endPos.transform.position, Time.deltaTime * tempo);

        if (transform.position == endPos.transform.position)
        {
            transform.position = Vector3.Lerp(endPos.transform.position, startPos.transform.position, Time.deltaTime * tempo);
        }
        
    }
}
