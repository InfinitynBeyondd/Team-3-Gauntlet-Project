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
    [SerializeField] GameObject WinScreen;

    private bool gameOver = false;

    private bool inWinMenu = false; 
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
        if(!gameOver && !inWinMenu)
        {
            LoseHealthOverTime();
        }

        if (currentHealth <= 0)
        {
            GameOver();
        }

        if (SceneManager.GetActiveScene().name == "WinMenu")
        {
            
            inWinMenu = true;
        }
        else
        {
            
            inWinMenu = false;
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
        gameOver = true;
        GameOverText.SetActive(true);
        StartCoroutine(GoToStart());
    }

    IEnumerator GoToStart()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Start_Menu");

    }
    public void WinGame()
    {
        gameOver = true;
        WinScreen.SetActive(true);
    }
}
