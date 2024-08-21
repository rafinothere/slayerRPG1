using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the player

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Use Input.GetAxis for the Vertical axis to move up and down
        float moveVertical = Input.GetAxis("Vertical");

        // Adjust the y component for up and down movement instead of the z component
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}