using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    Vector2 movementInput;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    Animator animator;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame

    private void FixedUpdate() {
        //if input is not 0, try to move
        if(movementInput != Vector2.zero){
            bool success = TryMove(movementInput);

            if (!success){
                success = TryMove(new Vector2(movementInput.x, 0));

                if (!success){
                    success = TryMove(new Vector2(0, movementInput.y));
                }
            }

            animator.SetBool("isMoving", success);
        } else{
            animator.SetBool("isMoving", false);
        }

        // set direction of sprite to movement direction
        if(movementInput.x < 0){
            spriteRenderer.flipX = true;
        } else if(movementInput.x > 0){
            spriteRenderer.flipX = false;
        }

        
        
    }   

    private bool TryMove(Vector2 direction){
        if (direction != Vector2.zero){
            int count = rb.Cast(
                direction,
                movementFilter,
                castCollision,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);

            if(count == 0){
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            } else{
                return false;
            }       
        } else {
            // can't move if there is no direction to move in
            return false;
        }
        
    }


    

    void OnMove(InputValue movementValue){
        movementInput = movementValue.Get<Vector2>();      
    }
}
