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
    private GameObject sphere;
    [SerializeField] private GameObject _currentTower = null;
    [SerializeField] private GameObject[] _typeOfTowers;

    [SerializeField] Camera _camera;

    private void Start()
    {
        _money = 150;
        
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
        _currentTower = tower.GetGameobjectType();
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
