using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyIdentifier : MonoBehaviour
{
    public GameObject allyPrefab; // Reference to the ally prefab

    void Awake()
    {
        // Ensure this GameObject is a prefab instance
        if (allyPrefab == null)
        {
            Debug.LogWarning("Ally prefab reference is not assigned in AllyIdentifier.");
        }
    }
}
