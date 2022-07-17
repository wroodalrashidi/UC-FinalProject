using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            Invoke("CompleteLevel", 2f);
        }
    }


    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
