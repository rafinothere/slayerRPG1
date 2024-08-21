using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefabReferences : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array of enemy prefabs

    // Optional: Method to get a prefab by index
    public GameObject GetEnemyPrefab(int index)
    {
        if (index >= 0 && index < enemyPrefabs.Length)
        {
            return enemyPrefabs[index];
        }
        return null;
    }
}