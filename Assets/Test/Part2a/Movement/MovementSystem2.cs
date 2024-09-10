using UnityEngine;

public class MovementSystem2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Moves the character in the given direction
    public void MoveCharacter(CharacterData character, Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            // Normalize the direction to ensure consistent movement speed
            Vector3 move = direction.normalized * moveSpeed * Time.deltaTime;
            character.transform.position += move;
        }
    }

    // Handles interactions with objects
    public void InteractWithObject(GameObject interactableObject)
    {
        // Check if the object is interactable
        IInteractable interactable = interactableObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            // Start the interaction
            StartInteraction(interactable);
        }
    }

    // Starts the interaction with an interactable object
    private void StartInteraction(IInteractable interactable)
    {
        // Access the currentCharacter from the GameManager
        CharacterData character = GameManager.Instance.currentCharacter;
        if (character != null)
        {
            interactable.Interact(character);
        }
        else
        {
            Debug.LogWarning("Current character is not set in GameManager.");
        }
    }
}
