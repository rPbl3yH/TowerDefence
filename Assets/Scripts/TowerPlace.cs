using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    public float yOffset = 0.2f;

    public bool isFree = true;
    public GameObject towerPrefab;

       
    private void OnMouseDown()
    {
        if (isFree)
        {
            Vector3 spawnTowerPosition = transform.position + new Vector3(0, yOffset, 0);
            GameObject tower = Instantiate(towerPrefab, spawnTowerPosition, Quaternion.identity);
            isFree = false;
        }
    }
}
