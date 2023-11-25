using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject powerUp;
    private float ZSpawnRange = 8.0f;
    private float enemySpawn = 8.0f;
    private float ZpowerUpSpawnRange = 8.0f;
    private float ySpawn = .75f;
    private float ySpawnPowerUp = .70f;
    private float StartDelay = 1.0f;
    private float PowerUpspawnTime = 5.0f;
    private float EnemyspawnTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomEnemy", StartDelay, EnemyspawnTime);
        InvokeRepeating("spawnPowerUp", StartDelay, PowerUpspawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void spawnRandomEnemy()
    {
        float RandomX = Random.Range(-ZSpawnRange, ZSpawnRange);
        int RandomIndex = Random.Range(0,Enemies.Length);

        Vector3 startPros = new Vector3(RandomX, ySpawn, enemySpawn);
        Instantiate(Enemies[RandomIndex], startPros, Quaternion.identity);

    }
    private void spawnPowerUp()
    {
        float RandomX = Random.Range(-ZSpawnRange, ZSpawnRange);
        float RandomZ = Random.Range(-ZpowerUpSpawnRange, ZpowerUpSpawnRange);

        Vector3 startPos = new Vector3(RandomX , ySpawnPowerUp, RandomZ);

        Instantiate(powerUp, startPos, Quaternion.identity);


    }
}