using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    enum TypesOfTower
    {
        Usual,
        Fast,
        Damaged
    }

    [SerializeField] private Text _moneyText;
    [SerializeField] private int _money;

    [SerializeField] private GameObject _currentTower = null;
    [SerializeField] private GameObject[] _typeOfTowers;

    private void Start()
    {
        _money = 100;
    }

    void Update()
    {
        _moneyText.text = _money.ToString();
    }

    public void AddMoney(int money)
    {
        _money += money;
    }

    public void SetTower(Tower tower)
    {
        for (int i = 0; i < _typeOfTowers.Length; i++)
        {
            if (_typeOfTowers[i].GetComponent(tower.ToString()))
            {
                _currentTower = _typeOfTowers[i];
                break;
            }
        }
        
    }

    public void Buy(int cost)
    {
        if(CanBuy(cost: cost))
        {
            _money -= cost;
        }

    }

    public GameObject GetCurrentTower()
    {
        return _currentTower;
    }

    public bool CanBuy(int cost)
    {
        return cost <= _money;
    }
}
