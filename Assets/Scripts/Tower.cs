using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject pivotTower;
    public GameObject gunOfTower;

    public Transform currentTarget;

    public float shootInteval;

    AudioSource audioSource;


    [SerializeField] bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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

        canShoot = true;

    }
}