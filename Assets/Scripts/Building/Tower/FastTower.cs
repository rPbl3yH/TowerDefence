using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTower : Tower
{
    public override void Initialize()
    {
        Cost = 40;
        Damage = 5;
        base.Initialize();
    }
}
