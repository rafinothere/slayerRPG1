using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdentifier : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab

    void Awake()
    {
        // Ensure this GameObject is a prefab instance
        if (enemyPrefab == null)
        {
            Debug.LogWarning("Enemy prefab reference is not assigned in EnemyIdentifier.");
        }
    }
}
