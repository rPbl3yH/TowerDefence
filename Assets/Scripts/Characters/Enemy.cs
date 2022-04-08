using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{
    public Transform[] waypoints;
    [SerializeField] public int DamageToBase; 
    [SerializeField] int currentIndexWaypoint = 0;
    private bool isOnBase;
    public int Money;

    public virtual void Update()
    {
        Transform currentWayPoint = waypoints[currentIndexWaypoint];

        transform.LookAt(currentWayPoint.position);
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentWayPoint.position,
            Time.deltaTime * Speed
            );

        if(Vector3.Distance(transform.position, currentWayPoint.position) < 0.1)
        {
            currentIndexWaypoint++;
            if(currentIndexWaypoint >= waypoints.Length)
            {
                isOnBase = true;
                Death();
            }
        }
        
    }
    public override void Death()
    {
        GameController controller = GameObject.FindGameObjectWithTag("GameController").
            GetComponent<GameController>();
        if(!isOnBase)
            controller.AddMoney(Money);
        Debug.Log("isOnBase = " + isOnBase);

        Destroy(GetComponent<HpBar>().hpText);
        base.Death();
    }

    public virtual void Initialize()
    {

    }
}
