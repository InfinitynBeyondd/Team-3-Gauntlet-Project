using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public void SetCorrectSprite(int lookX,int lookY) 
    {  
            //If looking right
            if (lookX == 1 && lookY == 0) { currentSprite.sprite = rightProjectile; }
            //If looking bottom right
            else if (lookX == 1 && lookY == -1) { currentSprite.sprite = bottomRightProjectile; }
            //If looking bottom 
            else if (lookX == 0 && lookY == -1) { currentSprite.sprite = bottomProjectile; }
            //If looking bottom left
            else if (lookX == -1 && lookY == -1) { currentSprite.sprite = bottomLeftProjectile; }
            //If looking left
            else if (lookX == -1 && lookY == 0) { currentSprite.sprite = leftProjectile; }
            //If looking top left
            else if (lookX == -1 && lookY == 1) { currentSprite.sprite = topLeftProjectile; }
            //If looking top
            else if (lookX == 0 && lookY == 1) { currentSprite.sprite = topProjectile; }
            //If looking top right
            else if (lookX == 1 && lookY == 1) { currentSprite.sprite = topRightProjectile; }
    }
}
