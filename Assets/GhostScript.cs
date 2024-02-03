using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private float healthPoints;
    [SerializeField] private float maxHealthPoints = 1;

    
    private Transform target; //Location of the player character
    [SerializeField] private float distance = 5f;

    void Start()
    {
        healthPoints = maxHealthPoints;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        MoveEnemy();

        if (healthPoints < 1)
        {
            Destroy(gameObject);
        }
    }

    private void MoveEnemy()
    {
        if (Vector2.Distance(transform.position, target.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))            
        {
            healthPoints -= 1;
        } 
    }
}
