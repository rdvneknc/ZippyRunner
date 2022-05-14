using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDelay : MonoBehaviour
{
  
    void Start()
    {
        
        StartCoroutine("DelayStart");
    }

    private void Update()
    {

        
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
