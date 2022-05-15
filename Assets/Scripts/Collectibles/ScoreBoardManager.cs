using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardManager : MonoBehaviour
{
    public static int keyCount;
    public GameObject scoreBoard;
    
    void Update()
    {
        scoreBoard.GetComponent<Text>().text = "" + keyCount;
    }
}
