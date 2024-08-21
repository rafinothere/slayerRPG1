using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySlotManager : MonoBehaviour
{
    public Transform[] allySlots; // Array of ally slot transforms
    private GameObject[] alliesInSlots; // Array of instantiated ally game objects

    void Start()
    {
        alliesInSlots = new GameObject[allySlots.Length];
    }

    // Method to assign an ally prefab to a slot
    public void AssignAllyToSlot(GameObject allyPrefab)
    {
        for (int i = 0; i < allySlots.Length; i++)
        {
            if (alliesInSlots[i] == null)
            {
                GameObject instantiatedAlly = Instantiate(allyPrefab, allySlots[i].position, Quaternion.identity);
                instantiatedAlly.transform.SetParent(allySlots[i]);

                // Set the rootAlly reference in each AllyHealth component
                AllyHealth[] allyParts = instantiatedAlly.GetComponentsInChildren<AllyHealth>();
                foreach (AllyHealth part in allyParts)
                {
                    part.rootAlly = instantiatedAlly;
                }

                alliesInSlots[i] = instantiatedAlly;
                break;
            }
        }
    }

    // Optional: Method to clear a slot (e.g., when an ally dies)
    public void ClearSlot(int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < alliesInSlots.Length)
        {
            alliesInSlots[slotIndex] = null;
        }
    }
}
