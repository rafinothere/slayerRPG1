using System.Collections.Generic;
using UnityEngine;

public class CombatStage : MonoBehaviour
{
    public List<CombatSlot> PlayerSlots;
    public List<CombatSlot> EnemySlots;

    private void Start()
    {
        // Initialize combat stage settings if necessary
    }

    public void Activate()
    {
        // Implement logic to activate the combat stage
        Debug.Log("Combat Stage Activated.");
    }

    public void Deactivate()
    {
        // Implement logic to deactivate the combat stage
        Debug.Log("Combat Stage Deactivated.");
    }

    public void AssignPlayer(CharacterData character, CombatSlot slot)
    {
        if (slot != null && character != null)
        {
            slot.SetOccupant(character);
            Debug.Log($"Player {character.Name} assigned to slot {slot.SlotNumber}.");
        }
        else
        {
            Debug.LogWarning("Cannot assign player. Slot or character is null.");
        }
    }

    public void AssignEnemy(EnemyData enemy, CombatSlot slot)
    {
        if (slot != null && enemy != null)
        {
            slot.SetOccupant(enemy);
            Debug.Log($"Enemy {enemy.Name} assigned to slot {slot.SlotNumber}.");
        }
        else
        {
            Debug.LogWarning("Cannot assign enemy. Slot or enemy is null.");
        }
    }
}
