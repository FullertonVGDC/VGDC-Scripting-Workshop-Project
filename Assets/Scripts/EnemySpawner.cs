using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTimerLength;
    float spawnTimer;

    public GameObject enemyPrefab;



    void Start()
    {
        spawnTimer = spawnTimerLength;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnTimerLength;
            Vector2 enemySpawnPosition = new Vector2(-10, Random.Range(-3.5f, 3.5f));
            Instantiate(enemyPrefab, enemySpawnPosition, Quaternion.identity);
        }
    }
}