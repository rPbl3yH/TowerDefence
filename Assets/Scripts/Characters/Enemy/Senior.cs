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

    // Start is called before the first frame update
    void Awake()
    {
        Initialize();
    }

    // Update is called once per frame
    
}
