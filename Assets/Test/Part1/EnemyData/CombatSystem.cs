using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public void SelectTarget(EnemyData enemy)
    {
        // Implement target selection logic
        Debug.Log($"Target selected: {enemy.Name}");
    }

    public void TargetBodyPart(BodyPart part)
    {
        // Implement body part targeting logic
        Debug.Log($"Targeting body part: {part.PartName}");
    }

    public void PerformAttack(AttackPattern attack, BodyPart target)
    {
        // Implement attack performance logic
        Debug.Log($"Performing {attack.Name} attack on {target.PartName}");
    }

    public void EndTurn()
    {
        // Implement turn end logic
        Debug.Log("Turn ended.");
    }
}
