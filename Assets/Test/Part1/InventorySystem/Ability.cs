using UnityEngine;

public class Ability : MonoBehaviour
{
    public string AbilityName;
    public int ManaCost;
    public int Damage;
    public string Effect;

    public void Activate(CharacterData target)
    {
        if (target == null)
        {
            Debug.LogWarning("Target character is null. Cannot activate ability.");
            return;
        }

        // Implement ability activation logic
        Debug.Log($"{AbilityName} activated on {target.Name}.");
    }
}
