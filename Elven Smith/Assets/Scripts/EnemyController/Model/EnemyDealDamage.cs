using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealDamage : MonoBehaviour
{
    [SerializeField]
    private float dealDamage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AttackPlayer(collision);
    }

    private void AttackPlayer(Collision2D player)
    {
        if (player.gameObject.layer == 6)
        {
            player.gameObject.GetComponent<PlayerHealth>().TakeDamage(dealDamage);
        }
    }
}
