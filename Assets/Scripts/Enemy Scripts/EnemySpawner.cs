using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int spawnerHP = 1;

    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private float _minimumSpawnTime = 1f;

    [SerializeField] private float _maximumpawnTime = 2f;

    private float _timeUntilSpawn;

    private void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnerHP < 1)
        {
            Destroy(gameObject);
        }

        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumpawnTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            spawnerHP -= 1;
        }
    }
}
