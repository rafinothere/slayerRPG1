using UnityEngine;

public class Weapon : Item
{
    public int Damage;
    public int Durability;

    public override void Use(CharacterData character)
    {
        // Implement weapon use logic
        Debug.Log($"{Name} used by {character.Name}. Damage: {Damage}");
    }

    public void Equip(CharacterData character)
    {
        character.EquipWeapon(this);
        Debug.Log($"{Name} equipped by {character.Name}.");
    }
}
