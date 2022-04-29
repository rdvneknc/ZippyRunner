using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    private Transform player;

    private float offsetY = 2f;
    private float offsetZ = -5f;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }


    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + offsetY, player.position.z + offsetZ);
    }
}
