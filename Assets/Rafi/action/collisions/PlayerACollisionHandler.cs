using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerACollisionHandler : MonoBehaviour
{
    public AllySlotManager slotManager; // Changed to public

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an ally root object
        if (collision.gameObject.CompareTag("Ally"))
        {
            // Get the AllyIdentifier component from the collided ally
            AllyIdentifier allyIdentifier = collision.gameObject.GetComponent<AllyIdentifier>();

            if (allyIdentifier != null && allyIdentifier.allyPrefab != null)
            {
                // Prompt the player to decide whether to add the ally to a slot
                StartCoroutine(AddAllyDecision(allyIdentifier.allyPrefab));
            }
            else
            {
                Debug.LogWarning("AllyIdentifier or allyPrefab is not set correctly on the collided ally.");
            }
        }
    }

    IEnumerator AddAllyDecision(GameObject allyPrefab)
    {
        // Display UI prompt to the player to add the ally (implementation of UI is assumed)
        // ...

        // Wait for the player to make a decision (implementation of player decision is assumed)
        bool playerDecision = false; // Change this based on player input

        while (!playerDecision)
        {
            yield return null; // Wait until the player makes a decision
        }

        if (playerDecision)
        {
            slotManager.AssignAllyToSlot(allyPrefab);
        }
    }
}
