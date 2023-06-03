using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   private Rigidbody2D rb;
   private BoxCollider2D coll;
   private Animator anim;
   [SerializeField] private LayerMask jumpableGround;
   private float directionX = 0f;
   private SpriteRenderer sprite;
  [SerializeField] private float moveSpeed = 7f;
  [SerializeField] private float jumpForce = 14f;
   private enum MovementState { idle , running , jumping , falling  }
    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
   private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       coll = GetComponent<BoxCollider2D>();
       anim = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
   private void Update()
    {
       directionX = Input.GetAxisRaw("Horizontal");
       rb.velocity = new Vector2(directionX * moveSpeed , rb.velocity.y);

       if(Input.GetButtonDown("Jump") && IsGrounded())
       {
        jumpSoundEffect.Play();
       rb.velocity = new Vector2(rb.velocity.x , jumpForce);
       }
        UpdateAnimationState();
    }


 private void UpdateAnimationState()


       {
          MovementState state;


         if(directionX>0f)
       {
       state = MovementState.running;
        sprite.flipX = false;
       }
       else if(directionX<0f)
       {
        state = MovementState.running;
        sprite.flipX = true;
       }
       else
       {
       state = MovementState.idle;
       }
       if(rb.velocity.y > 0.1f)
       {
         state = MovementState.jumping;
       }
       else if(rb.velocity.y < - 0.1f)
       {
         state = MovementState.falling;
       }

      anim.SetInteger("state", (int)state);


    }
      private bool IsGrounded(){
        return Physics2D.BoxCast(coll.bounds.center , coll.bounds.size , 0f , Vector2.down , 0.1f , jumpableGround);
      }
  
    
}  
