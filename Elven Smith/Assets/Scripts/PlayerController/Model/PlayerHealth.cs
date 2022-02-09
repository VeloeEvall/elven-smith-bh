using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float playerMaxHealth = 3;
    private float playerCurrentHealth;
    private void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }
    void Update()
    {
        if (playerCurrentHealth =< 0)
        {
            Die();
        }
    }

    public void TakeDamage(float enemyDamage)
    {
        playerCurrentHealth -= enemyDamage ;
    }

    private void Die()
    {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PlayerAim>().enabled = false;
    }
}
