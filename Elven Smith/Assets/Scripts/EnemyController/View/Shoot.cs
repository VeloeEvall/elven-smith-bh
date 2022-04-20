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
        Instantiate(miniEnemy, this.gameObject.transform.position, this.gameObject.transform.rotation);
        time = 0;
    }
}
