using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            PlayerStats playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            if (playerStats.numberOfKeys > 0)
            {
                playerStats.numberOfKeys -= 1;
                Destroy(gameObject);
            }
        }
    }
}
