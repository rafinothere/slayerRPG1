using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public DialogueUI dialogueUI; // Reference to the DialogueUI component
    public CharacterData characterData; // Reference to the CharacterData of the NPC

    // Method to start a dialogue with the NPC
    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogueUI != null)
        {
            // Show the dialogue using the DialogueUI component
            dialogueUI.ShowDialogue(dialogue);
        }
        else
        {
            // Log an error if DialogueUI is not assigned
            Debug.LogError("DialogueUI reference is missing!");
        }
    }

    // Optionally, you can add methods to interact with the NPC here
}
