using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlotManager : MonoBehaviour
{
    public Transform[] enemySlots; // Array of enemy slot transforms
    private GameObject[] enemiesInSlots; // Array of instantiated enemy game objects

    void Start()
    {
        enemiesInSlots = new GameObject[enemySlots.Length];
    }

    // Method to assign an enemy prefab to a slot
    public void AssignEnemyToSlot(GameObject enemyPrefab)
    {
        for (int i = 0; i < enemySlots.Length; i++)
        {
            if (enemiesInSlots[i] == null)
            {
                GameObject instantiatedEnemy = Instantiate(enemyPrefab, enemySlots[i].position, Quaternion.identity);
                instantiatedEnemy.transform.SetParent(enemySlots[i]);

                // Set the rootEnemy reference in each EnemyHealth component
                EnemyHealth[] enemyParts = instantiatedEnemy.GetComponentsInChildren<EnemyHealth>();
                foreach (EnemyHealth part in enemyParts)
                {
                    part.rootEnemy = instantiatedEnemy;
                }

                enemiesInSlots[i] = instantiatedEnemy;
                break;
            }
        }
    }

    // Optional: Method to clear a slot (e.g., when an enemy dies)
    public void ClearSlot(int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < enemiesInSlots.Length)
        {
            enemiesInSlots[slotIndex] = null;
        }
    }
}
