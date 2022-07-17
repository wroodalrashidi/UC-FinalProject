using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     float moveSpeed = 7f;
     Rigidbody2D rb;
    public GameObject target;
     Vector2 moveDirection;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    // target = gameObject.CompareTag("Player");

    moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
    rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
    Destroy(gameObject, 3f);
  }


   void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.name.Equals("Player"))
    {
        Destroy(gameObject);

    }
  }






}






