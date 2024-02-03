using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeTrigger : MonoBehaviour
{
    // Name of the level select scene
    public string levelSelectSceneName = "LevelSelect";

    // Check for player collision with the tile
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Im colliding");
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("The player is here");
            // Load the level select scene
            SceneManager.LoadScene(levelSelectSceneName);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Im colliding");
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("The player is here");
            // Load the level select scene
            SceneManager.LoadScene(levelSelectSceneName);

        }
    }
}

