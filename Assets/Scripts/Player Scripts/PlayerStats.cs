using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private float maxPlayerHealth = 800;
    [HideInInspector] public float currentHealth;

    public int numberOfKeys = 0;
    public int points = 0;
    public int numberOfBombs = 0;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        currentHealth = maxPlayerHealth;
    }

    private void Update()
    {
        LoseHealthOverTime();
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
