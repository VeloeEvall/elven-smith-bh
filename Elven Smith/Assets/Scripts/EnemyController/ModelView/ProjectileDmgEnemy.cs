using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDmgEnemy : MonoBehaviour
{
    [SerializeField]
    private float projectileDmgEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(projectileDmgEnemy);
        }
    }
}