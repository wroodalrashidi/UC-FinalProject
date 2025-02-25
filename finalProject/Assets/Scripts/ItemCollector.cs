using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
   
   private int goldCoins = 0;
    public AudioSource collectSE;


    [SerializeField] private Text goldCoinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoldCoin"))
        {
            collectSE.Play();
            Destroy(collision.gameObject);
            goldCoins++;
            goldCoinsText.text = "Gold coins: " + goldCoins;
        }
    }

}
