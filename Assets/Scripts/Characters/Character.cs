using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] public float Speed;
    [SerializeField] public int MaxHp, CurrentHp;



    // Start is called before the first frame update
    void Start()
    {
        CurrentHp = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
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
