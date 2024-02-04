using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Text healthText;
    [SerializeField] Text keysText;
    [SerializeField] Text bombsText;

    [SerializeField] PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = Mathf.FloorToInt(playerStats.currentHealth).ToString();

        keysText.text = playerStats.numberOfKeys.ToString();

        bombsText.text = playerStats.numberOfBombs.ToString();  
    }
}
