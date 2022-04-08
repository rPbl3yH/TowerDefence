using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senior : Enemy
{
    public override void Initialize()
    {
        base.Initialize();
        MaxHp = 50;
        Speed = 1;
        Money = 5;
    }

    void Awake()
    {
        Initialize();
    }    
}
