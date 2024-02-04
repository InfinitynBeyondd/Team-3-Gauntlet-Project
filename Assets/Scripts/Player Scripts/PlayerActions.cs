using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    //References to other player Scripts
    public PlayerController playerControllerInstance;

    [Header("Attack Action")]
    public GameObject attackProjectile;
    public float projectileSpeed = 20f;

    public GameObject pauseMenu;
    private bool isPaused = false;

    //Cj
    private Vector3 projectileSpawnOffset = new Vector3(1.5f, 1.5f, 0);

    void Start()
    {
        playerControllerInstance = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseMenu != null)
            {
                if (isPaused != true) { PauseGame(); }
                else { ResumeGame(); }
            }
            Debug.Log("I'm pressing stuffasasd");
            Debug.Log(pauseMenu);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Vector3 currentLookPosition = new Vector3((playerControllerInstance.lookX * projectileSpawnOffset.x), (playerControllerInstance.lookY * projectileSpawnOffset.y), 0);
            GameObject projectile = Instantiate(attackProjectile, gameObject.transform.position + currentLookPosition, gameObject.transform.rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.position + currentLookPosition * projectileSpeed, ForceMode2D.Impulse);
            
            ProjectileScript projectileScriptInstance = projectile.GetComponent<ProjectileScript>();
            projectileScriptInstance.SetCorrectSprite(playerControllerInstance.lookX, playerControllerInstance.lookY);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
}
