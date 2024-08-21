using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mapCamera; // Assign the "map cam" in the Inspector
    public Camera battleCamera;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Make sure to assign the "Player" tag to the player's collider
        {
            // Set the "map cam" as the active camera
        mapCamera.enabled = false;

        // Disable the main camera
        battleCamera.enabled = true;
    
        }
    }
}
