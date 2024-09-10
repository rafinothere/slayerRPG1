using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Dialogue CurrentDialogue;
    public CharacterData CurrentCharacter; // Make sure to assign this in your game

    // Starts a new dialogue
    public void StartDialogue(Dialogue dialogue)
    {
        CurrentDialogue = dialogue;
        DisplayNextSentence();
    }

    // Displays the next sentence in the dialogue
    public void DisplayNextSentence()
    {
        if (CurrentDialogue == null) return;

        string sentence = CurrentDialogue.GetNextSentence();
        Debug.Log(sentence);

        // Assuming you have a method to display the sentence in the UI
        // DisplaySentenceInUI(sentence); // Implement this based on your UI system
    }

    // Handles the player's choice and triggers events
    public void HandlePlayerChoice(DialogueChoice choice)
    {
        // Trigger events based on player choice
        foreach (var gameEvent in choice.Consequences)
        {
            if (CurrentCharacter != null)
            {
                gameEvent.Trigger(CurrentCharacter);
            }
            else
            {
                Debug.LogWarning("Current character is not set.");
            }
        }

        // Proceed to the next dialogue or end the dialogue
        DisplayNextSentence();
    }
}
