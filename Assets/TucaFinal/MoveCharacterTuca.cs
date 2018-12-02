using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterState1
{
    idle,
    walking,
    walkingBackward,
    running,
    crounching,
    pushing,
    dead
}

public class MoveCharacterTuca : MonoBehaviour
{

    public CharacterState1 characterState1;
    Rigidbody _rigidbody;
    Animator anim;

    public Camera cam;

    [Tooltip("Character Speed")]
    float speed;
    public float speedSmoothTime;

    float moveHorizontal;
    float moveVertical;

    public float walkSpeed;
    public float walkBackward;
    public float runSpeed;

    Vector3 movement;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        cam = Camera.main;

        speed = 0;
    }

    void Update()
    {

        #region COMENTADO
        /*
        #region Movement Character
        Vector3 right = cam.transform.right;
        Vector3 forward = Vector3.Cross(right, Vector3.up);

        //  float rotate = Input.GetAxis("Horizontal");

        // Vector3 movement = Vector3.zero;

        movement += right * (Input.GetAxis("Horizontal") * speed * Time.deltaTime);


        movement += this.transform.forward * (Input.GetAxis("Vertical") * speed * Time.deltaTime);
        #endregion       

        transform.Translate(movement * Time.deltaTime * speed);
        //_rigidbody.MovePosition(transform.position + movement * Time.deltaTime);

        // transform.Rotate(Vector3.up, rotate * 100 * Time.deltaTime);
        */
        #endregion


        //Parado
        if (movement == Vector3.zero)
        {
            speed = 0;
            characterState1 = CharacterState1.idle;
        }

        //Andando
        if (movement != Vector3.zero)
        {
            speed = walkSpeed;
            characterState1 = CharacterState1.walking;
        }

        if (moveVertical < -0.1f)
        {
            speed = walkBackward;
            characterState1 = CharacterState1.walkingBackward;

        }

        //Correndo
        if (Input.GetKey(KeyCode.LeftShift) && movement != Vector3.zero && moveVertical > 0)
        {

            speed = runSpeed;
            characterState1 = CharacterState1.running;
        }

        //INPUT
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        //INCREMENTA
        movement = new Vector3(0f, 0f, moveVertical);

        transform.Rotate(Vector3.up, moveHorizontal * 100 * Time.deltaTime);
        transform.Translate(movement * Time.deltaTime * speed);

        Animation(speed, moveVertical, moveHorizontal);

        print(moveVertical);
        Physics.IgnoreLayerCollision(10, 9, true);
        
    }

    void Animation(float velocidade, float running, float moveHorizontal)
    {


        anim.SetFloat("TurnSpeed", moveHorizontal/2, speedSmoothTime, Time.deltaTime);
        anim.SetFloat("SpeedPercent", velocidade * running, speedSmoothTime, Time.deltaTime);

    }
}
