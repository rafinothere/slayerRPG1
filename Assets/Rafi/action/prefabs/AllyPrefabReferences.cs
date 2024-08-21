using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyPrefabReferences : MonoBehaviour
{
    public GameObject[] allyPrefabs; // Array of ally prefabs

    // Optional: Method to get a prefab by index
    public GameObject GetAllyPrefab(int index)
    {
        if (index >= 0 && index < allyPrefabs.Length)
        {
            return allyPrefabs[index];
        }
        return null;
    }
}
