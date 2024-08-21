using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zPlayerCollisionHandler : MonoBehaviour
{
    public EnemySlotManager enemySlotManager; // Slot manager for enemies
    public AllySlotManager allySlotManager; // Slot manager for allies

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HandleEnemyCollision(collision);
        }
        else if (collision.gameObject.CompareTag("Ally"))
        {
            HandleAllyCollision(collision);
        }
    }

    private void HandleEnemyCollision(Collision2D collision)
    {
        // Get the EnemyIdentifier component from the collided enemy
        EnemyIdentifier enemyIdentifier = collision.gameObject.GetComponent<EnemyIdentifier>();

        if (enemyIdentifier != null && enemyIdentifier.enemyPrefab != null)
        {
            // Assign the enemy prefab to an available slot
            enemySlotManager.AssignEnemyToSlot(enemyIdentifier.enemyPrefab);
        }
        else
        {
            Debug.LogWarning("EnemyIdentifier or enemyPrefab is not set correctly on the collided enemy.");
        }

        // Destroy the collided enemy root object
        Destroy(collision.gameObject);
    }

    private void HandleAllyCollision(Collision2D collision)
    {
        // Get the AllyIdentifier component from the collided ally
        AllyIdentifier allyIdentifier = collision.gameObject.GetComponent<AllyIdentifier>();

        if (allyIdentifier != null && allyIdentifier.allyPrefab != null)
        {
            // Prompt the player to decide whether to add the ally via console input
            StartCoroutine(ConsolePromptToAddAlly(allyIdentifier.allyPrefab));
        }
        else
        {
            Debug.LogWarning("AllyIdentifier or allyPrefab is not set correctly on the collided ally.");
        }
    }

    private IEnumerator ConsolePromptToAddAlly(GameObject allyPrefab)
    {
        // Display a console message to prompt the player
        Debug.Log("Do you want to add this ally to your party? (Y/N)");

        // Wait for player input (this is a simulated wait, replace with actual input handling in your game)
        yield return StartCoroutine(WaitForInput(input =>
        {
            if (input.Trim().ToLower() == "y")
            {
                allySlotManager.AssignAllyToSlot(allyPrefab);
            }
            else
            {
                Debug.Log("Ally not added to the party.");
            }
        }));
    }

    private IEnumerator WaitForInput(System.Action<string> callback)
    {
        bool inputReceived = false;
        string input = string.Empty;

        // Simulate waiting for input (replace with actual input handling logic)
        while (!inputReceived)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                input = "y";
                inputReceived = true;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                input = "n";
                inputReceived = true;
            }

            yield return null;
        }

        callback(input);
    }
}
