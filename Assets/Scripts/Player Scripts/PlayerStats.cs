using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private float maxPlayerHealth = 800;
    [HideInInspector] public float currentHealth;
    public int numberOfKeys = 0;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxPlayerHealth;
    }

    private void Update()
    {
        LoseHealthOverTime();
        Debug.Log(currentHealth);
    }

    private void LoseHealthOverTime()
    {
        currentHealth -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ghost"))
        {
            currentHealth -= 5;
        }
    }
}
