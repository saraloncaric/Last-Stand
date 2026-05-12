using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    public List<GameObject> enemyPrefabs = new List<GameObject>();
    public Transform spawnPoint;

    [SerializeField, Min(0f)]
    [Tooltip("Koliko sekundi čeka nakon što val završi spawn prije sljedećeg vala.")]
    float timeBetweenWaves = 8f;

    [SerializeField, Min(1)]
    int enemiesPerWave = 5;

    int _waveIndex;

    void Start()
    {
        if (spawnPoint == null)
            Debug.LogWarning("WaveSpawner: spawnPoint nije postavljen.");

        if (enemyPrefabs == null || enemyPrefabs.Count == 0)
            Debug.LogWarning("WaveSpawner: lista enemyPrefabs je prazna.");

        StartCoroutine(RunWaves());
    }

    IEnumerator RunWaves()
    {
        while (true)
        {
            _waveIndex++;
            Debug.Log($"Val {_waveIndex} kreće!");

            for (int i = 0; i < enemiesPerWave; i++)
                SpawnOneEnemy();

            if (timeBetweenWaves > 0f)
                yield return new WaitForSeconds(timeBetweenWaves);
        }
    }

    void SpawnOneEnemy()
    {
        if (spawnPoint == null || enemyPrefabs == null || enemyPrefabs.Count == 0)
            return;

        GameObject prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        if (prefab == null)
            return;

        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
