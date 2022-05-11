using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float changePositionSpeed = 10f;

    

    [SerializeField]
    private CharacterController characterController;

    // Update is called once per frame
     void Update()
    {

        Vector3 direction = Vector3.forward * Time.deltaTime * movementSpeed;

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

        characterController.Move(direction);


      
    }

    
}
