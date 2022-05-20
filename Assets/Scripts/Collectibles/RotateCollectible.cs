using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    public float rotationSpeed = 0.001f;


    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
