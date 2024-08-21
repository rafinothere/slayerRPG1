using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public GameObject rootAlly; // Reference to the root ally object

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
        if (rootAlly != null)
        {
            Destroy(rootAlly); // Destroy the root ally object
        }
        else
        {
            Destroy(gameObject); // Destroy only this part if rootAlly is not set
        }
    }
}
