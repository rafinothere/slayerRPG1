using UnityEngine;

public class CombatSystem2 : MonoBehaviour
{
    public int playerHealth = 100;
    public int enemyHealth = 100;
    public int damageAmount = 10;

    public SoundAssets soundAssets;
    public ArtAssets artAssets;

    // Method to handle player attacking an enemy
    public void PlayerAttack()
    {
        enemyHealth -= damageAmount;
        Debug.Log("Player attacked! Enemy health: " + enemyHealth);

        soundAssets.CreateSoundEffects("Attack");

        if (enemyHealth <= 0)
        {
            EnemyDefeated();
        }
    }

    // Method to handle enemy attacking the player
    public void EnemyAttack()
    {
        playerHealth -= damageAmount;
        Debug.Log("Enemy attacked! Player health: " + playerHealth);

        soundAssets.CreateSoundEffects("Hit");

        if (playerHealth <= 0)
        {
            PlayerDefeated();
        }
    }

    // Method called when the enemy is defeated
    private void EnemyDefeated()
    {
        Debug.Log("Enemy defeated!");
        // Trigger death animation or effects
        artAssets.GetCharacterSprite("EnemyDefeatedSprite");
        // Further logic for handling enemy defeat
    }

    // Method called when the player is defeated
    private void PlayerDefeated()
    {
        Debug.Log("Player defeated!");
        // Trigger game over or respawn logic
        artAssets.GetCharacterSprite("PlayerDefeatedSprite");
        // Further logic for handling player defeat
    }
}
