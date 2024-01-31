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

    //Cj
    private Vector3 projectileSpawnOffset = new Vector3(0.7f, 0.7f, 0);

    void Start()
    {
        playerControllerInstance = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Vector3 currentLookPosition = new Vector3((playerControllerInstance.lookX * projectileSpawnOffset.x), (playerControllerInstance.lookY * projectileSpawnOffset.y), 0);
            GameObject projectile = Instantiate(attackProjectile, gameObject.transform.position + currentLookPosition, gameObject.transform.rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.position + currentLookPosition * projectileSpeed, ForceMode2D.Impulse);
        }
    }
}
