using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the inspector
    public float detectionRadius = 5f;
    public float moveSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer < detectionRadius)
        {
            FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        // Calculate the direction vector from the enemy to the player
        Vector2 direction = (player.position - transform.position).normalized;
        // Move the enemy in that direction
        rb.velocity = direction * moveSpeed;
    }

    // New method to handle collision with player's collider
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Make sure to assign the "Player" tag to the player's collider
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition; // This line freezes the enemy's position and rotation
        }
    }
}