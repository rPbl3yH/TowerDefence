using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTriggerTower : MonoBehaviour
{
    public Tower tower;
    [SerializeField] Transform currentTarget;

    void Start()
    {
        tower = gameObject.GetComponentInParent<Tower>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !currentTarget)
        {
            currentTarget = other.transform;
            tower.currentTarget = currentTarget;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Enemy") && currentTarget == other.transform)
        {
            currentTarget = null;
            tower.currentTarget = currentTarget;
        }
    }

    
}
