using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public GameObject rootEnemy; // Reference to the root enemy object

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (rootEnemy != null)
        {
            Destroy(rootEnemy); // Destroy the root enemy object
        }
        else
        {
            Destroy(gameObject); // Destroy only this part if rootEnemy is not set
        }
    }
}
