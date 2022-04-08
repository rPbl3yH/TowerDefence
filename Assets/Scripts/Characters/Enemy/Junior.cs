using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junior : Enemy
{
    public override void Initialize()
    {
        MaxHp = 10;
        Speed = 5;
    }

    private void Awake()
    {
        Initialize();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
