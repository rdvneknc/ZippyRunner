using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDelay : MonoBehaviour
{

    void Start()
    {
        
        StartCoroutine("DelayStart");
    }



    IEnumerator DelayStart()
    {

        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3;
         while (Time.realtimeSinceStartup < pauseTime)
           yield return 0;
        Time.timeScale = 1;

    }
}
