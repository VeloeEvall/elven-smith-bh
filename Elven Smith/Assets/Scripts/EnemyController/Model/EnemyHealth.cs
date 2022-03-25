using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float enemyMaxHealth;
    private float enemyCurrentHealth;
    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    public void EnemyTakeDamage(float playerDamage)
    {
        enemyCurrentHealth -= playerDamage;
        if (enemyCurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<EnemyDetection>().enabled = false;
        GetComponent<EnemyDealDamage>().enabled = false;
        Debug.Log("Œmieræ Pu³kownika");
        Destroy(this.gameObject, 2);
    }
}
