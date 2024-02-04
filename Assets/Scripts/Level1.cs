using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    void Update()
    {
        // Check for key press to load the scene
        if (Input.GetKeyDown(KeyCode.Return)) // Use KeyCode.Alpha1 instead of KeyCode.1
        {
            LoadLevel1Scene();
        }
    }

    public void Level1()
    {
        LoadLevel1Scene();
    }

    private void LoadLevel1Scene()
    {
        // Load the scene asynchronously
        SceneManager.LoadSceneAsync("Gauntlet_Level_1_Prototype 1");
    }
}
