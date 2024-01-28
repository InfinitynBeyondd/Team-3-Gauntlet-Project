using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the character movement

    private Rigidbody2D rb2d; // Reference to the Rigidbody2D component

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // Getting the Rigidbody2D component attached to the GameObject
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical input from the player
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputY = Input.GetAxis("Vertical");

        // Calculate the velocity vector
        Vector2 moveVelocity = new Vector2(moveInputX * moveSpeed, moveInputY * moveSpeed);

        // Apply the velocity to the Rigidbody2D
        rb2d.velocity = moveVelocity;

        // Update the sprite's position based on Rigidbody2D's velocity
        transform.position += (Vector3)moveVelocity * Time.deltaTime;
    }
}
