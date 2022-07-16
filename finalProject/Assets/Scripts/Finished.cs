using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finished : MonoBehaviour
{
 
 public AudioSource winSound;

   private  void Start()
    {
        winSound = GetComponent<AudioSource>();
    }

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            winSound.Play();
            CompleteLevel();
        }
    }


    private void CompleteLevel()
    {

    }
}
