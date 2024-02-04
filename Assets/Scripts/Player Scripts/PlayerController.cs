using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public int lookX;
    public int lookY;
    private bool isMoving = false;
    public Vector2 currentLook;

    private bool isInLevel2 = false;

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

        if (horizontal > 0.1 || vertical > 0.1 || horizontal < -0.1 || vertical < -0.1)
        {
            isMoving = true;
            playerAnimator.SetBool("isMoving", isMoving);
        }
        else {isMoving= false; playerAnimator.SetBool("isMoving", isMoving); }

        GetLookDirection();

        playerAnimator.SetFloat("LookX", lookX);
        playerAnimator.SetFloat("LookY", lookY);


        playerAnimator.SetFloat("moveX", horizontal);
        playerAnimator.SetFloat("moveY", vertical);

        if (SceneManager.GetActiveScene().name == "Gauntlet_Level_2" && isInLevel2 == false)
        {
            transform.position = new Vector3(2,-2,0);
            isInLevel2 = true;
        }
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

    void GetLookDirection()
    {
        //If looking right
        if (horizontal > 0.1 && vertical == 0) { lookX = 1; lookY = 0; }
        //If looking bottom right
        else if (horizontal > 0.1 && vertical < -0.1) { lookX = 1; lookY = -1; }
        //If looking bottom 
        else if (horizontal == 0 && vertical < -0.1) { lookX = 0;  lookY = -1;}
        //If looking bottom left
        else if (horizontal < -0.1 && vertical < -0.1) { lookX= -1; lookY = -1; }
        //If looking left
        else if (horizontal < -0.1 && vertical == 0) { lookX = -1; lookY = 0; }
        //If looking top left
        else if (horizontal < -0.1 && vertical > 0.1) { lookX = -1; lookY = 1; }
        //If looking top
        else if (horizontal == 0 && vertical > 0.1) { lookX = 0; lookY = 1; }
        //If looking top right
        else if (horizontal > 0.1 && vertical > 0.1) { lookX = 1; lookY = 1; }
    }
}
