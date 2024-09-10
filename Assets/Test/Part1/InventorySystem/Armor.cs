using UnityEngine;

public class Armor : Item
{
    public int Defense;
    public int Durability;

    public override void Use(CharacterData character)
    {
        // Implement armor use logic
        Debug.Log($"{Name} used by {character.Name}. Defense: {Defense}");
    }

    public void Equip(CharacterData character)
    {
        character.EquipArmor(this);
        Debug.Log($"{Name} equipped by {character.Name}.");
    }
}
