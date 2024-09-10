using UnityEngine;

public class CombatSlot : MonoBehaviour
{
    public int SlotNumber; // Identifier for the slot
    public bool Occupied { get; private set; } // Indicates if the slot is currently occupied
    public CharacterData Occupant { get; private set; } // The character currently occupying the slot

    // Assign a character to this slot
    public void SetOccupant(CharacterData character)
    {
        if (character != null)
        {
            Occupant = character;
            Occupied = true;
            Debug.Log($"{character.name} has been assigned to slot {SlotNumber}.");
        }
        else
        {
            Debug.LogWarning("Cannot assign a null character to the slot.");
        }
    }

    // Clear the character from this slot
    public void ClearSlot()
    {
        if (Occupied)
        {
            Debug.Log($"Clearing slot {SlotNumber}, which was occupied by {Occupant.name}.");
            Occupant = null;
            Occupied = false;
        }
    }
}
