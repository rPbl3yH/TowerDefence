using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSenior : Spawner
{
    public override void Initialize()
    {
        for (int i = 0; i < EnemyPrefabs.Length; i++)
        {
            if (EnemyPrefabs[i].GetComponent<Senior>())
            {
                CurrentEnemyPrefab = EnemyPrefabs[i];
                break;
            }
        }
    }
}
