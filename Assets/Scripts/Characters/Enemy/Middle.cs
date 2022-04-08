using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : Enemy
{
    public override void Initialize()
    {
        MaxHp = 30;
        Speed = 2f;
    }


    // Start is called before the first frame update
    void Awake()
    {
        Initialize();
    }

    // Update is called once per frame
    
}
