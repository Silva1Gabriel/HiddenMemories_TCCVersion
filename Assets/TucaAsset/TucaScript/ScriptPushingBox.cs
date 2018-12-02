using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPushingBox : MonoBehaviour
{
    public GameObject personagem;
    Rigidbody rdb;
    CharacterController characterController;
    CapsuleCollider capsuleCollider;
    ScriptPersonagem scriptPersonagem;

    float mHorizontal;
    float mVertical;

    Vector3 moveInput;

    public float moveSpeed;

    public bool InteractWBox;

    // Use this for initialization
    void Start()
    {
        scriptPersonagem = GetComponent<ScriptPersonagem>();
        characterController = GetComponent<CharacterController>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        rdb = GetComponent<Rigidbody>();

        //        rdb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

    }

    // Update is called once per frame
    void Update()
    {
        MovimentoPersonagem();
        /*
        if (characterController.enabled == false)
        {
            if (InteractWBox)
            {
                VerificarPosicaoPlayer();
            }
        }*/
    }


    void MovimentoPersonagem()
    {
        if (rdb == null)
        {
            print("esta nulo");
        }

        if (rdb != null)
        {
            print("ñ esta nulo");
        }
        mHorizontal = Input.GetAxis("Horizontal");
        mVertical = Input.GetAxis("Vertical");

        moveInput = new Vector3(mHorizontal, 0, mVertical);
        moveInput = moveInput.normalized;

        if (Input.GetKeyDown(KeyCode.E))
        {
            TesteScript();
        }
    }

    void TesteScript()
    {

        print("Funcionado");

        capsuleCollider.enabled = false;
        scriptPersonagem.enabled = true;
        characterController.enabled = true;
        this.enabled = false;

    }

    private void FixedUpdate()
    {
        rdb.velocity = transform.position + transform.forward + moveInput * moveSpeed;
    }


    void VerificarPosicaoPlayer()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            InteractWBox = true;
        }
    }
}
