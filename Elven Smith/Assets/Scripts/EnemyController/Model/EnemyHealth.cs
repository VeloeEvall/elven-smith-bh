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
    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            Die();
        }
    }

    public void EnemyTakeDamage(float playerDamage)
    {
        enemyCurrentHealth -= playerDamage;
    }

    private void Die()
    {
        GetComponent<EnemyDetection>().enabled = false;
        GetComponent<EnemyDealDamage>().enabled = false;
        Debug.Log("Œmieræ Pu³kownika");
    }
}
