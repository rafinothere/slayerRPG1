using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public CombatStage combatStage;

    public void SwitchToCombatStage()
    {
        // Logic to switch to the combat stage
        combatStage.Activate();
        Debug.Log("Switched to Combat Stage.");
    }

    public void SwitchToDialogueStage(Dialogue dialogue)
    {
        // Logic to switch to the dialogue stage
        if (dialogueManager != null && dialogue != null)
        {
            dialogueManager.StartDialogue(dialogue);
            Debug.Log("Switched to Dialogue Stage.");
        }
        else
        {
            Debug.LogWarning("Cannot switch to Dialogue Stage. DialogueManager or Dialogue is null.");
        }
    }
}
