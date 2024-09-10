using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueChoice
{
    [SerializeField]
    private string choiceText; // Text to display for this choice

    [SerializeField]
    private List<GameEvent> consequences; // List of game events triggered by this choice

    public string ChoiceText
    {
        get { return choiceText; }
    }

    public List<GameEvent> Consequences
    {
        get { return consequences; }
    }

    public void OnChoiceSelected()
    {
        // This method can be used to handle additional logic when the choice is selected
        // For example, you might want to play a sound effect or animate UI elements
    }
}
