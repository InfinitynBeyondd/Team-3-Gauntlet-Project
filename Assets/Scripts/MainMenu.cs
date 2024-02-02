using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        // Check for key press to load the scene
        if (Input.GetKeyDown(KeyCode.Return)) // Use KeyCode.Alpha1 instead of KeyCode.1
        {
            LoadCharacterSelectScene();
        }
    }

    public void PlayGame()
    {
        LoadCharacterSelectScene();
    }

    private void LoadCharacterSelectScene()
    {
        // Load the scene asynchronously
        SceneManager.LoadSceneAsync("Character_SelectKnight");
    }
}