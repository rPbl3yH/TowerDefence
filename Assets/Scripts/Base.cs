using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public Text HpBaseText;

    [SerializeField] int _currentHp = 100;
    public GameObject GameLoseWindow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            
            GiveDamage(enemy.DamageToBase);
            enemy.Death();
        }
    }

    void GiveDamage(int damage)
    {
        _currentHp -= damage;
        HpBaseText.text = _currentHp.ToString();
    }
}
