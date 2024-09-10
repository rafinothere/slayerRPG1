using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E; // Key for interaction
    public float moveSpeed = 5f; // Movement speed

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component is missing from the player GameObject.");
        }
    }

    void Update()
    {
        // Process movement input
        Vector2 movementInput = GetMovementInput();
        MovePlayer(movementInput);

        // Process interaction input
        GameObject interactableObject = GetInteractionInput();
        if (interactableObject != null)
        {
            Debug.Log($"Interacting with: {interactableObject.name}");
        }
    }

    // Get the player's movement input as a Vector2
    private Vector2 GetMovementInput()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Check for WASD keys and map to horizontal and vertical axes
        if (Input.GetKey(KeyCode.W)) vertical += 1f;
        if (Input.GetKey(KeyCode.S)) vertical -= 1f;
        if (Input.GetKey(KeyCode.A)) horizontal -= 1f;
        if (Input.GetKey(KeyCode.D)) horizontal += 1f;

        Vector2 movementInput = new Vector2(horizontal, vertical);
        Debug.Log($"Movement Input: {movementInput}");

        return movementInput;
    }

    // Move the player based on the input
    private void MovePlayer(Vector2 movementInput)
    {
        if (rb != null)
        {
            Vector2 moveVelocity = movementInput.normalized * moveSpeed;
            rb.velocity = moveVelocity;
        }
    }

    // Get the player's interaction input, returns the GameObject the player is trying to interact with
    private GameObject GetInteractionInput()
    {
        if (Input.GetKeyDown(interactKey))
        {
            Debug.Log("Interact key pressed");

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log($"Interactable object detected: {hit.collider.gameObject.name}");
                return hit.collider.gameObject;
            }
            else
            {
                Debug.Log("No interactable object detected");
            }
        }

        return null; // Return null if no object was hit
    }
}
