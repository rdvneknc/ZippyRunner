using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    public float movementSpeed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed;
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;

        transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement) * Time.deltaTime);
    }

}
