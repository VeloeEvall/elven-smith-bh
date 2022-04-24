using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject miniEnemy;
    [SerializeField]
    float time;
    [SerializeField]
    float timeToShoot;
    [SerializeField]
    GameObject bulletSpawner;
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeToShoot)
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        Instantiate(miniEnemy, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
        time = 0;
    }
}
