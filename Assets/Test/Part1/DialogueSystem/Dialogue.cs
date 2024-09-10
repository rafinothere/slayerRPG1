using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    private Queue<string> sentences;
    public List<DialogueChoice> Choices;

    private void Start()
    {
        sentences = new Queue<string>();
        // Initialize sentences and choices as needed
    }

    public string GetNextSentence()
    {
        if (sentences.Count == 0)
        {
            return string.Empty;
        }

        return sentences.Dequeue();
    }

    public List<DialogueChoice> GetChoices()
    {
        return Choices;
    }
}
