using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : Enemy
{
    public override void Initialize()
    {
        base.Initialize();
        MaxHp = 30;
        Speed = 2f;
        Money = 3;
    }

    void Awake()
    {
        Initialize();
    }

    
}
