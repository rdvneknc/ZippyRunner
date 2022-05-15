using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    public float changePositionSpeed = 10.0f;

    public float jumpForce = 5.0f;
    public float gravity = -20.0f;

    //private Rigidbody rb;
    //public float horizontalMovement;

    [SerializeField]
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = Vector3.forward * Time.deltaTime * movementSpeed;
        
        direction.y += gravity * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > RoadBoundaries.leftSide)
            {
                direction += Vector3.left * Time.deltaTime * changePositionSpeed;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < RoadBoundaries.rightSide)
            {
                direction += Vector3.right * Time.deltaTime * changePositionSpeed;
            }
        }

        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpForce;
                transform.Translate(new Vector3(0, direction.y, 0) * Time.deltaTime, Space.World);
            }
        }
      

        characterController.Move(direction);


    }

    /*void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed;

        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * changePositionSpeed * horizontalMovement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }*/


}
