using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : Building
{
    [SerializeField] public int Damage, Cost;
    
    public GameObject bulletPrefab;
    public GameObject pivotTower;
    public GameObject gunOfTower;

    public Transform currentTarget;

    public float shootInteval;

    AudioSource audioSource;


    [SerializeField] bool canShoot = true;

    public virtual void Initialize()
    {

    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (currentTarget)
        {
            
            pivotTower.transform.LookAt(currentTarget);
            if (canShoot)
            {
                StartCoroutine(shoot());
            }
        }
        else
        {
            StopCoroutine(shoot());
        }
        
        
    }

    IEnumerator shoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(shootInteval);
        GameObject bullet = Instantiate(bulletPrefab, gunOfTower.transform.position, Quaternion.identity) as GameObject;
        audioSource.PlayOneShot(audioSource.clip);

        bullet.GetComponent<BulletMovement>().target = currentTarget;
        bullet.GetComponent<BulletMovement>().damage = Damage;

        canShoot = true;

    }

    public virtual GameObject GetGameobjectType()
    {
        return gameObject;
    }

    

}
