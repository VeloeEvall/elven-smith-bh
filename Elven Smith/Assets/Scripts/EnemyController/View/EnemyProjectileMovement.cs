using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float lifeSpan;
    float time;
    [SerializeField]
    private Transform player;
    private Vector3 destination;

    private void Start()
    {
        destination = (player.transform.position - transform.position).normalized;
    }
    void Update()
    {
        time += Time.deltaTime; 
        transform.localPosition += new Vector3(destination.x, destination.y, 0) * speed * Time.deltaTime;
        if(time >= lifeSpan)
        {
            Destroy(this.gameObject);
        }
    }
}
