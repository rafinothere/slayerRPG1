using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InGameHUD : MonoBehaviour
{
    public Text healthText; // UI Text for displaying health
    public Text manaText; // UI Text for displaying mana
    public Text sanityText; // UI Text for displaying sanity
    public InventoryUI inventoryUI; // Reference to InventoryUI for showing items
    public DialogueUI dialogueUI; // Reference to DialogueUI for displaying dialogue

    // Update health display
    public void DisplayHealth(int health)
    {
        healthText.text = "Health: " + health.ToString();
    }

    // Update mana display
    public void DisplayMana(int mana)
    {
        manaText.text = "Mana: " + mana.ToString();
    }

    // Update sanity display
    public void DisplaySanity(int sanity)
    {
        sanityText.text = "Sanity: " + sanity.ToString();
    }

    // Display the player's inventory
    public void DisplayInventory(List<Item> items)
    {
        inventoryUI.ShowInventory(items);
    }

    // Display dialogue on the HUD
    public void DisplayDialogue(Dialogue dialogue)
    {
        dialogueUI.ShowDialogue(dialogue);
    }
}
