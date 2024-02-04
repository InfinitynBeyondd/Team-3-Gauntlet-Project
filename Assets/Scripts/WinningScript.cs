using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    [SerializeField] string levelName; 
    [SerializeField] Text pointsText;
    [SerializeField] Text healthText;
    [SerializeField] Text keysText;
    [SerializeField] Text bombsText;

    private PlayerStats playerStats;
    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void update()
    {
        pointsText.text = playerStats.points.ToString();

        healthText.text = Mathf.FloorToInt(playerStats.currentHealth).ToString();

        keysText.text = playerStats.numberOfKeys.ToString();

        bombsText.text = playerStats.numberOfBombs.ToString();
    }
}
