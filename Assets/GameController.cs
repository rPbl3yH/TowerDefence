using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _moneyText;
    [SerializeField] private int _money;
    
    void Update()
    {
        _moneyText.text = _money.ToString();
    }

    public void AddMoney(int money)
    {
        _money += money;
    }
}
