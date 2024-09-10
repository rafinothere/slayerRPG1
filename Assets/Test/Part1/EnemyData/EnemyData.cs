using System.Collections.Generic;
using UnityEngine;

public class EnemyData : CharacterData
{
    public List<AttackPattern> AttackPatterns;
    public List<BodyPart> BodyParts;

    public void TakeDamage(int damage, BodyPart part)
    {
        part.Health -= damage;
        Debug.Log($"{Name} took {damage} damage to {part.PartName}. Remaining health: {part.Health}");
    }

    public AttackPattern SelectAttack()
    {
        // Implement attack selection logic
        return AttackPatterns.Count > 0 ? AttackPatterns[0] : null; // Example logic
    }

    public new void AffectSanity(int amount)
    {
        // Implement logic specific to affecting sanity for enemies
        Sanity += amount;
        Debug.Log($"{Name}'s sanity changed by {amount}. Current sanity: {Sanity}");
    }
}