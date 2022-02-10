using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    [SerializeField]
    private float projectileDmg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<EnemyHealth>().EnemyTakeDamage(projectileDmg);
    }
}
