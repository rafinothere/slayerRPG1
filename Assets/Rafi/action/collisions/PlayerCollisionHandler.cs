using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public EnemySlotManager slotManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an enemy root object
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Get the EnemyIdentifier component from the collided enemy
            EnemyIdentifier enemyIdentifier = collision.gameObject.GetComponent<EnemyIdentifier>();

            if (enemyIdentifier != null && enemyIdentifier.enemyPrefab != null)
            {
                // Assign the enemy prefab to an available slot
                slotManager.AssignEnemyToSlot(enemyIdentifier.enemyPrefab);
            }
            else
            {
                Debug.LogWarning("EnemyIdentifier or enemyPrefab is not set correctly on the collided enemy.");
            }

            // Destroy the collided enemy root object
            Destroy(collision.gameObject);
        }
    }
}
