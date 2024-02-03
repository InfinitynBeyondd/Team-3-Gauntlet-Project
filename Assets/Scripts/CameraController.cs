using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public Vector3 offset;   // Offset of the camera from the player

    Vector2 tempPos; 


    void LateUpdate()
    {
        if (target != null)
        {
            // Update the position of the camera to follow the player with the defined offset
            transform.position = target.position + offset;

            // Debug.Log the positions for troubleshooting
            Debug.Log("Target Position: " + target.position);
            Debug.Log("Camera Position: " + transform.position);

                tempPos = transform.position;
                tempPos.y = -10f;
        }
    }
}