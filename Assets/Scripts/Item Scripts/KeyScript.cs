using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            playerStats.numberOfKeys += 1;
            Destroy(gameObject);
        }
    }
}
