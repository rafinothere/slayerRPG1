using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueUI : MonoBehaviour
{
    public Text dialogueText; // UI Text for displaying the dialogue text
    public Button choiceButtonPrefab; // Prefab for choice buttons
    public Transform choicesPanel; // Panel to hold the choice buttons

    // Method to show dialogue and choices
    public void ShowDialogue(Dialogue dialogue)
    {
        if (dialogue == null)
        {
            Debug.LogError("Dialogue is null!");
            return;
        }

        // Display the dialogue text
        string sentence = dialogue.GetNextSentence();
        if (dialogueText != null)
        {
            dialogueText.text = sentence;
        }
        else
        {
            Debug.LogError("Dialogue Text is not assigned!");
        }

        // Clear previous choices
        foreach (Transform child in choicesPanel)
        {
            Destroy(child.gameObject);
        }

        // Instantiate and configure buttons for each choice
        if (choiceButtonPrefab != null && choicesPanel != null)
        {
            List<DialogueChoice> choices = dialogue.GetChoices();
            foreach (var choice in choices)
            {
                Button choiceButton = Instantiate(choiceButtonPrefab, choicesPanel);
                Text buttonText = choiceButton.GetComponentInChildren<Text>();
                
                if (buttonText != null)
                {
                    buttonText.text = choice.ChoiceText;
                }
                else
                {
                    Debug.LogError("Button Text component is missing in the prefab!");
                }
                
                // Add listener to handle choice selection
                choiceButton.onClick.AddListener(() => HandleChoice(choice));
            }
        }
        else
        {
            Debug.LogError("Choice Button Prefab or Choices Panel is not assigned!");
        }
    }

    // Method to handle the player's choice
    private void HandleChoice(DialogueChoice choice)
    {
        if (choice != null)
        {
            choice.OnChoiceSelected(); // Call any additional logic for the choice
            // You might need to access the DialogueManager or other components here
            // Example: DialogueManager.Instance.HandlePlayerChoice(choice);
        }
        else
        {
            Debug.LogError("DialogueChoice is null!");
        }
    }
}
