using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] public float Speed;
    [SerializeField] public int MaxHp, CurrentHp;

    void Start()
    {
        CurrentHp = MaxHp;
    }

    public virtual void TakeDamage(int damage)
    {
        CurrentHp -= damage;
        if (CurrentHp <= 0)
            Death();
    }

    public virtual void Death()
    {
        Debug.Log($"Gameobject {gameObject.name} is destroyed");
        Destroy(gameObject);
    }
}
