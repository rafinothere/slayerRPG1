using UnityEngine;

public class AttackPattern : MonoBehaviour
{
    public string Name; // Name of the attack pattern (e.g., "Slash", "Fireball")
    public int Damage; // Base damage of the attack pattern

    // Method to affect a specific body part
    public void AffectPart(BodyPart part)
    {
        if (part != null)
        {
            // Apply the attack’s effect to the specified body part
            part.ApplyDamage(Damage);
            Debug.Log($"{Name} attack affects {part.PartName} with {Damage} damage.");
        }
        else
        {
            Debug.LogWarning("No valid body part specified for the attack.");
        }
    }
}
