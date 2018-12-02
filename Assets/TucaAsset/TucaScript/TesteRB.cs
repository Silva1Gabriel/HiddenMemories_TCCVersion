using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteRB : MonoBehaviour
{
    Rigidbody rdb;

    float mHorizontal;
    float mVertical;

    Vector3 moveInput;

    private void Start()
    {
        rdb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        mHorizontal = Input.GetAxis("Horizontal");
        mVertical = Input.GetAxis("Vertical");

        moveInput = new Vector3(mHorizontal, 0, mVertical);
        moveInput = moveInput.normalized;
    }

    private void FixedUpdate()
    {
        rdb.MovePosition(transform.position + moveInput * 0.5f);
    }


}
