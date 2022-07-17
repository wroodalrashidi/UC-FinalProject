using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator animation;
    private BoxCollider2D collider;


    public LayerMask jumpableGround;

    private float directionX = 0f;
    public float speed = 7f;
    public float jump = 14f;

    private enum MovementState{idel, running, jumping}

    public AudioSource jumpSE;
    

    [HideInInspector] public bool isFacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animation = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
        
    }

    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);

       if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            jumpSE.Play();
        }

        UpdateAnimationState();

    }
    
    private void UpdateAnimationState()
    {
        MovementState state;

       if(directionX > 0f ) 
        {
            state = MovementState.running;
             sprite.flipX = true;        
        } 
        else if (directionX < 0f )
        {
            state = MovementState.running;
            sprite.flipX = false;
        } 
        else 
        {
            state = MovementState.idel;
        }

        if (rb.velocity.y > -.1f)
        {
            state = MovementState.jumping;
        }

        animation.SetInteger("state", (int)state);

    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
