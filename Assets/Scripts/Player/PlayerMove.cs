using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float changePositionSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > RoadBoundaries.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * changePositionSpeed);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < RoadBoundaries.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * changePositionSpeed);
            }
        }

      
        

    }
}
