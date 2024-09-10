using UnityEngine;

public class CharacterData : MonoBehaviour
{
    public string Name;
    public int Health;
    public int Mana;
    public int Sanity;

    public void EquipWeapon(Weapon weapon)
    {
        // Implement weapon equip logic
    }

    public void EquipArmor(Armor armor)
    {
        // Implement armor equip logic
    }

    public void UseAbility(Ability ability)
    {
        // Implement ability usage logic
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{Name} took {damage} damage. Remaining health: {Health}");
    }

    public void AffectSanity(int amount)
    {
        Sanity += amount;
        Debug.Log($"{Name}'s sanity changed by {amount}. Current sanity: {Sanity}");
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Implement dialogue start logic
    }
}
