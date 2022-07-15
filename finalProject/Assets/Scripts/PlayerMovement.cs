using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator animation;

    private float directionX = 0f;
    public float speed = 7f;
    public float jump = 14f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animation = GetComponent<Animator>();
    }

    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);

       if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }

        UpdateAnimationState();

    }
    
    private void UpdateAnimationState()
    {

       if(directionX > 0f ) 
        {
            animation.SetBool("running", true);
             sprite.flipX = true;        
        } 
        else if (directionX < 0f )
        {
            animation.SetBool("running", true);
            sprite.flipX = false;
        } 
        else 
        {
            animation.SetBool("running", true);   
        }

    }
}
