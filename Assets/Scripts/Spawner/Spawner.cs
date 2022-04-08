using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    

    [SerializeField] public GameObject[] EnemyPrefabs;
    [SerializeField] public GameObject CurrentEnemyPrefab;
    [SerializeField] private float _startTime;
    [SerializeField] private float _intervalSpawnTime;

    [SerializeField] private int _countEnemyWave = 5;
    [SerializeField] private int _currentCountEnemy = 0;

    [SerializeField] private Transform[] _waypointsOfSpawn;
    [SerializeField] private GameObject _canvas;



    public virtual void Start()
    {
        Initialize();
        StartCoroutine(SpawnEnemyWave(_countEnemyWave));
    }

    public virtual void SpawnEnemy()
    {
        GameObject enemy = Instantiate(CurrentEnemyPrefab, transform.position, Quaternion.identity);
        _currentCountEnemy++;

        enemy.GetComponent<Enemy>().waypoints = _waypointsOfSpawn;
        enemy.GetComponent<HpBar>().canvas = _canvas;
    }

    IEnumerator SpawnEnemyWave(int waveEnemyCount)
    {
        yield return new WaitForSeconds(_startTime);
        for (int i = 0; i < waveEnemyCount; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(_intervalSpawnTime);
        }
    }

    public virtual void Initialize()
    {
        CurrentEnemyPrefab = EnemyPrefabs[0];
    }
}
