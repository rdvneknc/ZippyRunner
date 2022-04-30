using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public int zPosition = 200;
    public bool createSection = false;
    public int sectionNumber;

   
    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 200;
        yield return new WaitForSeconds(6);
        createSection = false;
    }
}
