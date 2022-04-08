using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMiddle : Spawner
{
    public override void Initialize()
    {
        for (int i = 0; i < EnemyPrefabs.Length; i++)
        {
            if (EnemyPrefabs[i].GetComponent<Middle>())
            {
                CurrentEnemyPrefab = EnemyPrefabs[i];
                break;
            }
        }

    }
}
