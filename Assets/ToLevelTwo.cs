using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Public function to be called when the button is clicked
    public void Level2()
    {
        SceneManager.LoadSceneAsync("Gauntlet_Level_2");
    }
}
