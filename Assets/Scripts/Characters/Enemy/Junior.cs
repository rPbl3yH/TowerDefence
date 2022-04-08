using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junior : Enemy
{
    public override void Initialize()
    {
        base.Initialize();
        MaxHp = 10;
        Speed = 5;
        Money = 2;
    }

    private void Awake()
    {
        Initialize();
    }
    

}
