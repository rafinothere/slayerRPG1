using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    // This method is called when a character interacts with this object
    public void Interact(CharacterData character)
    {
        // Log the interaction for debugging
        Debug.Log($"{character.name} interacted with {gameObject.name}");

        // Perform the interaction-specific logic
        OnInteract(character);
    }

    // This method is meant to be overridden in derived classes for specific interactions
    protected virtual void OnInteract(CharacterData character)
    {
        // Default interaction behavior (can be extended in subclasses)
        Debug.Log($"{gameObject.name} interaction handled.");
    }
}
