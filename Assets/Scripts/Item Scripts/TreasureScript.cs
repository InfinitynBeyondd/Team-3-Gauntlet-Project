using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            playerStats.points += 1;
            Destroy(gameObject);
        }
        }
    }
