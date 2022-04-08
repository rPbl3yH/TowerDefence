using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : Building
{
    public Text HpBaseText;

    public GameObject GameLoseWindow;

    private void Awake()
    {
        MaxHp = 100;
    }

    private void Update()
    {
        HpBaseText.text = "Base: " + CurrentHP.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            
            TakeDamage(enemy.DamageToBase);
            enemy.Death();
        }
    }
}
