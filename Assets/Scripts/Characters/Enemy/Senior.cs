using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senior : Enemy
{
    public override void Initialize()
    {
        MaxHp = 50;
        Speed = 1;
    }

    void Awake()
    {
        Initialize();
    }    
}
