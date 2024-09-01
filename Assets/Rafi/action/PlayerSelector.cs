using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public List<Transform> players; // List of enemy transforms
    public Transform cameraTransform; // The camera transform
    public GameObject stopperObject; // Object to stop the rotation when collided with
    public float maxRotationSpeed = 100f; // Maximum rotation speed
    public float minRotationSpeed = 23f; // Minimum rotation speed
    public float stopDistance = 10f; // Distance at which rotation speed transitions to minRotationSpeed
    public float delayBeforeStop = 1f; // Delay before the rotation stops, adjustable in Inspector
    public float initialEKeyPressDelay = 2f; // Delay before the first automated E press, adjustable in Inspector

    [SerializeField]
    private Transform selectedPlayer; // Display selected enemy in Inspector
    private int currentIndex = 0;
    private Rigidbody rb;
    private Vector3 initialPosition;
    private Vector3 initialScale;
    private bool rotationStopped = false;
    private Coroutine stopRotationCoroutine; // Reference to the running coroutine
    private Coroutine initialEKeyPressCoroutine; // Reference to the coroutine for initial E key press

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePosition;

        // Store the initial position and scale of the object
        initialPosition = transform.position;
        initialScale = transform.localScale;

        if (players.Count > 0)
        {
            currentIndex = Random.Range(0, players.Count);
            SelectEnemy(currentIndex);
            
            // Start the coroutine to handle the delayed first E key press
            initialEKeyPressCoroutine = StartCoroutine(AutomateFirstEKeyPress());
        }
    }

    void Update()
    {
        // Maintain rotation constraints and locked position/scale
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePosition;

        // Reset position and scale to ensure they remain locked
        transform.position = initialPosition;
        transform.localScale = initialScale;

        if (Input.GetKeyDown(KeyCode.E))
        {
            SelectNextEnemy();
        }
    }

    void FixedUpdate()
    {
        if (selectedPlayer != null && !rotationStopped)
        {
            RotateTowardsSelectedEnemy();
        }
    }

    void SelectNextEnemy()
    {
        if (players.Count > 0)
        {
            currentIndex = (currentIndex + 1) % players.Count;
            SelectEnemy(currentIndex);
        }
    }

    void SelectEnemy(int index)
    {
        // Disable all enemy colliders
        foreach (var enemy in players)
        {
            Collider collider = enemy.GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = false;
            }
        }

        // Enable the collider of the selected enemy
        selectedPlayer = players[index];
        EnableSelectedEnemyCollider();

        // Reset the rotationStopped flag to allow rotation towards the new enemy
        rotationStopped = false;
    }

    void EnableSelectedEnemyCollider()
    {
        Collider selectedCollider = selectedPlayer.GetComponent<Collider>();
        if (selectedCollider != null)
        {
            selectedCollider.enabled = true;
        }
    }

    void RotateTowardsSelectedEnemy()
    {
        Vector3 directionToEnemy = selectedPlayer.position - transform.position;
        directionToEnemy.y = 0f;  // Ensure the rotation is only around the Y-axis

        // Calculate the target rotation around Y-axis
        Quaternion targetRotation = Quaternion.LookRotation(directionToEnemy);
        float targetYRotation = targetRotation.eulerAngles.y;

        // Get the current Y rotation
        float currentYRotation = transform.eulerAngles.y;

        // Calculate distance to the stopper
        float distanceToStopper = Vector3.Distance(selectedPlayer.position, stopperObject.transform.position);

        // Calculate the rotation speed based on distance to the stopper
        float speedBasedOnDistance = Mathf.Lerp(maxRotationSpeed, minRotationSpeed, Mathf.InverseLerp(stopDistance, 0f, distanceToStopper));

        // Ensure the speed does not go below minRotationSpeed
        float rotationSpeed = Mathf.Max(speedBasedOnDistance, minRotationSpeed);

        // Calculate the new Y rotation, rotating towards the target angle
        float newYRotation = Mathf.MoveTowardsAngle(currentYRotation, targetYRotation, rotationSpeed * Time.deltaTime);

        // Apply the new Y rotation while keeping X and Z unchanged
        transform.rotation = Quaternion.Euler(0f, newYRotation, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (stopperObject != null && other.gameObject == stopperObject)
        {
            // Stop any existing coroutine before starting a new one
            if (stopRotationCoroutine != null)
            {
                StopCoroutine(stopRotationCoroutine);
            }

            // Start the coroutine to handle the delay before stopping rotation
            stopRotationCoroutine = StartCoroutine(DelayBeforeStopRotation());

            Debug.Log("Collision detected. Delay before stopping rotation initiated.");
        }
    }

    IEnumerator DelayBeforeStopRotation()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeStop);

        // Stop the rotation by setting the rotationStopped flag to true
        rotationStopped = true;

        // Also, zero out any remaining angular velocity
        rb.angularVelocity = Vector3.zero;

        Debug.Log("Rotation stopped. Enemy is aligned with the camera.");
    }

    IEnumerator AutomateFirstEKeyPress()
    {
        // Wait for the specified delay before simulating the E key press
        yield return new WaitForSeconds(initialEKeyPressDelay);

        // Simulate the E key press
        SelectNextEnemy();
        Debug.Log("Automated initial E key press executed.");
    }
}
