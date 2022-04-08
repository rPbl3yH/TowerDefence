using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerJunior : Spawner
{
    public override void Initialize()
    {
        for (int i = 0; i < EnemyPrefabs.Length; i++)
        {
            if (EnemyPrefabs[i].GetComponent<Junior>())
            {
                CurrentEnemyPrefab = EnemyPrefabs[i];
                break;
            }
        }
    }


}
