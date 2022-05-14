using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float changePositionSpeed = 10f;

   
    public float jumpForce = 5.0f;
    public float gravity = -20;



    //[SerializeField]
    public CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
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
                transform.Translate(new Vector3(0, direction.y, 0) * Time.deltaTime);
            }
        }
      

        characterController.Move(direction); 

    }




}
