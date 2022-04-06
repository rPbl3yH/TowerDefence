using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{

    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _startTime;
    [SerializeField] private float _intervalSpawnTime;

    [SerializeField] private int _countEnemyWave = 5;
    [SerializeField] private int _currentCountEnemy = 0;

    [SerializeField] private Transform[] _waypointsOfSpawn;
    [SerializeField] private GameObject _canvas;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", _startTime, _intervalSpawnTime);
    }

    void SpawnEnemy()
    {
        
        GameObject enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        _currentCountEnemy++;

        enemy.GetComponent<Enemy>().waypoints = _waypointsOfSpawn;
        enemy.GetComponent<HpBar>().canvas = _canvas;

        if (_currentCountEnemy == _countEnemyWave)
            CancelInvoke("SpawnEnemy");

    }
}
