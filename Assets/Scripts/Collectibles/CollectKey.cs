using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public AudioSource coinSound;
    private void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        this.gameObject.SetActive(false);
    }
}
