using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedTower : Tower
{
    public override void Initialize()
    {
        Cost = 50;
        Damage = 20;
        base.Initialize();
    }
}
