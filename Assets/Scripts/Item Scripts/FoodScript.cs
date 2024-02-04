using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            playerStats.currentHealth += 100;
            Destroy(gameObject);
        }
        }
    }
