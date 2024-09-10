using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public string PartName; // The name of the body part (e.g., "Head", "Arm")
    public int Health; // The health of the body part
    public float DamageMultiplier; // Multiplier for damage dealt to this body part
    public bool IsCritical; // Indicates if this body part is critical (e.g., a vital organ)

    // Method to apply damage to this body part
    public void ApplyDamage(int damage)
    {
        if (Health <= 0)
        {
            Debug.LogWarning($"{PartName} is already destroyed.");
            return;
        }

        // Calculate effective damage based on the multiplier
        int effectiveDamage = Mathf.RoundToInt(damage * DamageMultiplier);
        Health -= effectiveDamage;

        Debug.Log($"{PartName} took {effectiveDamage} damage.");

        // Check if the body part is destroyed
        if (Health <= 0)
        {
            Health = 0; // Ensure health does not go below zero
            OnDestruction();
        }
    }

    // Method called when the body part is destroyed
    private void OnDestruction()
    {
        Debug.Log($"{PartName} is destroyed.");

        if (IsCritical)
        {
            // Handle critical body part destruction
            Debug.Log("Critical body part destroyed! This may have additional effects.");
        }
        
        // Add additional destruction logic here (e.g., visual effects, status effects)
    }
}
