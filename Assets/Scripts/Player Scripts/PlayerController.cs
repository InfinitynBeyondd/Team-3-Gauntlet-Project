using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    private bool isMoving = false;
    //float moveLimiter = 0.7f;
    private Animator playerAnimator;

    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxis("Horizontal"); // -1 is left
        vertical = Input.GetAxis("Vertical"); // -1 is down

        if (horizontal > 0.1 || vertical > 0.1 || horizontal > -0.1 || vertical > -0.1)
        {
            isMoving = true;
            playerAnimator.SetBool("isMoving", isMoving);
        }
        else {isMoving= false; playerAnimator.SetBool("isMoving", isMoving); }

        playerAnimator.SetFloat("moveX", horizontal);
        playerAnimator.SetFloat("moveY", vertical);
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            //horizontal *= moveLimiter;
            //vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
