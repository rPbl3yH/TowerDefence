using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public Text hpBaseText;

    [SerializeField] int currentHp = 100;
    public int damageFromEnemy = 10;

    public GameObject gameLoseWindow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().EnemyDestroy();
            GiveDamage();
        }
    }

    void GiveDamage()
    {
        currentHp -= damageFromEnemy;
        hpBaseText.text = currentHp.ToString();
    }
}
