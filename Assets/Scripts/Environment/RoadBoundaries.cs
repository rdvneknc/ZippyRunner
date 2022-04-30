using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBoundaries : MonoBehaviour
{
    public static float leftSide = -10f;
    public static float rightSide = 34f;
    public float internalLeftSide;
    public float internalRightSide;

    void Start()
    {
        internalRightSide = rightSide;
        internalLeftSide = leftSide;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
