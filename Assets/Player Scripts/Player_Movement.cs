using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Player_Movement : MonoBehaviour
{
    public InputActionReference movementInput;
    public Rigidbody2D body;
    public float playerSpeed;
    public float playerRotation;
    public float playerRotationSpeed = 2;


    void Update()
    {
        playerRotation = movementInput.action.ReadValue<float>();
        body.transform.Rotate(0, 0, playerRotation * playerRotationSpeed);
        body.linearVelocity = new Vector2(playerRotation * playerSpeed, body.linearVelocity.y);
    }
}
