using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public Transform[] waypoints;

    public int currentHp = 30;

    public GameObject hpPrefab;
    [SerializeField] int currentIndexWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform currentWayPoint = waypoints[currentIndexWaypoint];

        transform.LookAt(currentWayPoint.position);
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentWayPoint.position,
            Time.deltaTime * speed
            );

        if(Vector3.Distance(transform.position, currentWayPoint.position) < 0.1)
        {
            currentIndexWaypoint++;
            if(currentIndexWaypoint == waypoints.Length)
            {
                EnemyDestroy();
            }
        }
        
    }

    public void GiveDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log("Current HP enemy - " + currentHp);
        if (currentHp <= 0)
        {
            EnemyDestroy();
        }
            
    }

    public void EnemyDestroy()
    {
        Destroy(gameObject);
        Destroy(GetComponent<HpBar>().hpText);
    }
}
