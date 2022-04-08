using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [SerializeField] public int MaxHp, CurrentHP;

    private void Start()
    {
        CurrentHP = MaxHp;
    }

    public virtual void TakeDamage(int damage)
    {
        CurrentHP -= damage;
        if (CurrentHP <= 0)
            Destroy();
    }
    
    public virtual void Destroy()
    {
        Destroy(gameObject);
    }
}
