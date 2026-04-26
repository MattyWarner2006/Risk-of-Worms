using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public InputActionReference movementInput;
    public InputActionReference sprintInput;
    public Rigidbody2D body;
    public float playerSpeed;
    public float playerMaxSpeed;
    public float playerRotation;
    public float playerRotationSpeed = 1;


    void Update()
    {
        //read input value then rotate the player
        playerRotation = movementInput.action.ReadValue<float>();
        body.transform.Rotate(0, 0, playerRotation * playerRotationSpeed);

        switch (sprintInput.action.IsInProgress())
        {
            //increment players speed when activated
            case true:
                playerSpeed++;
                break;
            case false:
                playerSpeed = playerMaxSpeed;
                break;
        }
    }

    private void FixedUpdate()
    {
        //give player constant movement
        body.AddForce(transform.up * playerSpeed);
    }
    
}
