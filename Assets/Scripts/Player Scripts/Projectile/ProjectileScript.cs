using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{


    //Where the projectile will spawn at
    public Vector3 spawnPosition;

    //Will need to change sprite depending on where it is facing
    
    private SpriteRenderer currentSprite;
    private Rigidbody currentRigidbody;

    [Header("Projectile Sprites")]
    public Sprite topProjectile;
    public Sprite topRightProjectile;
    public Sprite rightProjectile;
    public Sprite bottomRightProjectile;
    public Sprite bottomProjectile;
    public Sprite bottomLeftProjectile;
    public Sprite leftProjectile;
    public Sprite topLeftProjectile;

    void Start()
    {
        currentSprite = GetComponent<SpriteRenderer>();
        currentRigidbody = GetComponent<Rigidbody>();   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
