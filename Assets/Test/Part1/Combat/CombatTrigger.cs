using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTrigger : MonoBehaviour
{
    // This method will be called to trigger a combat scenario
    public void TriggerCombat()
    {
        Debug.Log("Combat has been triggered.");
        
        // Assuming you have a TransitionManager to handle stage transitions
        TransitionManager transitionManager = FindObjectOfType<TransitionManager>();
        if (transitionManager != null)
        {
            transitionManager.SwitchToCombatStage();
        }
        else
        {
            Debug.LogWarning("TransitionManager not found in the scene.");
        }
    }
}
