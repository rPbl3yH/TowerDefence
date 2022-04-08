using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsualTower : Tower
{
    public override void Initialize()
    {
        Cost = 30;
        Damage = 10;
        base.Initialize();
    }
}
