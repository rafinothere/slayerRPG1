using UnityEngine;

public class Book : Item
{
    public string Title;
    public int MagicPower;

    public override void Use(CharacterData character)
    {
        // Implement book use logic
        Debug.Log($"{Title} used by {character.Name}. Magic Power: {MagicPower}");
    }

    public void LearnAbility(CharacterData character)
    {
        // Implement learning ability logic
        Debug.Log($"{Title} teaches a new ability to {character.Name}.");
    }

    public void InflictCurse(CharacterData character)
    {
        // Implement inflicting curse logic
        Debug.Log($"{Title} inflicts a curse on {character.Name}.");
    }
}
