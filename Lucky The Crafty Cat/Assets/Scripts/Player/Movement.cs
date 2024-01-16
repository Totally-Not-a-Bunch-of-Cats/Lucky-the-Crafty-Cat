using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Controls the movements of the player model
/// </summary>
public class Movement : MonoBehaviour
{
    
    // The speed at which the player moves
    [SerializeField] float movementSpeed = 0.01f;
    // The height that the player can jump
    [SerializeField] float jumpHeight = 2f;
    // The health of the player
    [SerializeField] float playerHealth = 100f;

    // Update is called once per frame
    void Update()
    {
        // When the user presses the w key or up arrow
        if(Input.GetButton("Forward"))
        {
            Forward();
        }

        // When the user presses the s key or down arrow
        if(Input.GetButton("Backward"))
        {
            Backward();
        }

        // When the user presses the a key or left arrow
        if(Input.GetButton("Left"))
        {
            Left();
        }

        // When the user presses the d key or right arrow
        if(Input.GetButton("Right"))
        {
            Right();
        }

        // When the user presses the space
        if(Input.GetButtonDown("Jump") && gameObject.transform.position.y == 1)
        {
            Jump();
        }

        // When the user presses either shift
        if(Input.GetButton("Run"))
        {
            Run();
        }
        else
        {
            movementSpeed = 0.01f;
        }
    }

    /// <summary>
    /// Moves the player forward/up
    /// </summary>
    void Forward()
    {
        Vector3 forwardTransform = new Vector3(0, 0, movementSpeed);
        gameObject.transform.position += forwardTransform;
    }

    /// <summary>
    /// Moves the player backward/down
    /// </summary>
    void Backward()
    {
        Vector3 backwardTransform = new Vector3(0, 0, -movementSpeed);
        gameObject.transform.position += backwardTransform;
    }

    /// <summary>
    /// Moves the player to the left
    /// </summary>
    void Left()
    {
        Vector3 leftTransform = new Vector3(-movementSpeed, 0, 0);
        gameObject.transform.position += leftTransform;
    }

    /// <summary>
    /// Moves the player to the right
    /// </summary>
    void Right()
    {
        Vector3 rightTransform = new Vector3(movementSpeed, 0, 0);
        gameObject.transform.position += rightTransform;
    }

    /// <summary>
    /// Makes the player jump
    /// </summary>
    void Jump()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

    /// <summary>
    /// Makes the player move at double speed
    /// </summary>
    void Run()
    {
        movementSpeed = 0.02f;
    }
}
