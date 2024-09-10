using UnityEngine;

public enum EventType
{
    HealthIncrease,
    ManaIncrease,
    SanityDecrease,
    // Add other event types as needed
}

public class GameEvent : MonoBehaviour
{
    public EventType EventType;

    // Trigger the event, affecting the given character
    public void Trigger(CharacterData character)
    {
        if (character == null)
        {
            Debug.LogWarning("CharacterData is null. Cannot trigger event.");
            return;
        }

        switch (EventType)
        {
            case EventType.HealthIncrease:
                // Example logic: Increase the character's health
                character.Health += 10; // Adjust the amount as needed
                Debug.Log($"{character.Name}'s health increased. New health: {character.Health}");
                break;

            case EventType.ManaIncrease:
                // Example logic: Increase the character's mana
                character.Mana += 5; // Adjust the amount as needed
                Debug.Log($"{character.Name}'s mana increased. New mana: {character.Mana}");
                break;

            case EventType.SanityDecrease:
                // Example logic: Decrease the character's sanity
                character.Sanity -= 5; // Adjust the amount as needed
                Debug.Log($"{character.Name}'s sanity decreased. New sanity: {character.Sanity}");
                break;

            // Handle other event types as needed
            default:
                Debug.LogWarning("Unknown EventType. No action taken.");
                break;
        }
    }
}
