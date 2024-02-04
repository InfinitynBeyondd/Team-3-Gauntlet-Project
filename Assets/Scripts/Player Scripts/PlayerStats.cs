using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] GameObject GameOverText;
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

        if (currentHealth <= 0)
        {
            GameOver();
        }
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

    private void GameOver()
    {
        Time.timeScale = 0;
        GameOverText.SetActive(true);
        StartCoroutine(GoToStart());
    }

    IEnumerator GoToStart()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Start_Menu");

    }
}
