using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeTrigger : MonoBehaviour
{
    // Name of the level select scene
    public string levelSelectSceneName = "LevelSelect";

    // Check for player collision with the tile
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Load the level select scene
            SceneManager.LoadScene(levelSelectSceneName);
        }
    }
}
