using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler
{
    public float YOffset = 0.2f;

    public bool IsFree = true;
    
    private GameObject _towerPrefab;
    private GameController _gameController;

    private void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController").
            GetComponent<GameController>();

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _towerPrefab = _gameController.GetCurrentTower();
        if (_towerPrefab)
        {
            int towerCost = _towerPrefab.GetComponent<Tower>().Cost;

            if (IsFree && _gameController.CanBuy(towerCost))
            {
                _gameController.Buy(towerCost);

                Vector3 spawnTowerPosition = transform.position + new Vector3(0, YOffset, 0);
                GameObject tower = Instantiate(
                    _towerPrefab,
                    spawnTowerPosition,
                    Quaternion.identity);
                IsFree = false;
            }
        }
        
    }



    
}
