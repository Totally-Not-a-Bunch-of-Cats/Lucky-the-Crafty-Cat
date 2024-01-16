using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    // The speed at which the player moves
    float movementSpeed = 1f;
    // The height that the player can jump
    float jumpHeight = 2f;
    // Gravity
    float gravity = 9.8f;
    // Vector that the player is moving by
    Vector3 movementVector = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When the user presses the w key or up arrow
        if(Input.GetKeyDown("Forward"))
        {
            Forward();
        }

        // When the user presses the s key or down arrow
        if(Input.GetKeyDown("Backward"))
        {
            Backward();
        }

        // When the user presses the a key or left arrow
        if(Input.GetKeyDown("Left"))
        {
            Left();
        }

        // When the user presses the d key or right arrow
        if(Input.GetKeyDown("Right"))
        {
            Right();
        }

        // When the user presses the space
        if(Input.GetKeyDown("Jump"))
        {
            Jump();
        }
    }

    /// <summary>
    /// Moves the player forward/up
    /// </summary>
    void Forward()
    {
        
    }

    /// <summary>
    /// Moves the player backward/down
    /// </summary>
    void Backward()
    {

    }

    /// <summary>
    /// Moves the player to the left
    /// </summary>
    void Left()
    {

    }

    /// <summary>
    /// Moves the player to the right
    /// </summary>
    void Right()
    {

    }

    /// <summary>
    /// Makes the player jump
    /// </summary>
    void Jump()
    {

    }
}
