using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler
{
    public float yOffset = 0.2f;

    public bool isFree = true;
    public GameObject towerPrefab;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isFree)
        {
            Vector3 spawnTowerPosition = transform.position + new Vector3(0, yOffset, 0);
            GameObject tower = Instantiate(towerPrefab, spawnTowerPosition, Quaternion.identity);
            isFree = false;
        }
    }
}
