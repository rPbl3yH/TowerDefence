using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    enum TypeOfEnemies
    {
        Junior,
        Middle,
        Senior
    }

    [SerializeField] public GameObject[] EnemyPrefabs;
    [SerializeField] public GameObject CurrentEnemyPrefab;
    [SerializeField] private float _startTime;
    [SerializeField] private float _intervalSpawnTime;

    [SerializeField] private int _countEnemyWave = 5;

    [SerializeField] private Transform[] _waypointsOfSpawn;
    [SerializeField] private GameObject _canvas;

    [SerializeField]private TypeOfEnemies _typeOfEnemies;

    public virtual void Start()
    {
        Initialize();
        StartCoroutine(SpawnEnemyWave(_countEnemyWave));
    }

    public virtual void SpawnEnemy()
    {
        GameObject enemy = Instantiate(CurrentEnemyPrefab, transform.position, Quaternion.identity);

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
        switch (_typeOfEnemies)
        {
            case TypeOfEnemies.Junior:
                CurrentEnemyPrefab = EnemyPrefabs[0];
                break;
            case TypeOfEnemies.Middle:
                CurrentEnemyPrefab = EnemyPrefabs[1];
                break;
            case TypeOfEnemies.Senior:
                CurrentEnemyPrefab = EnemyPrefabs[2];
                break;
        }
        
    }

    
}
