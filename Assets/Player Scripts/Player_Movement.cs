using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D body;
    public float playerVelocity;
    public float leftRotation;
    public float rightRotation;


    void Update()
    {
     
    }

    public void Movement(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            leftRotation = ctx.ReadValue<Vector2>().x;
            rightRotation = ctx.ReadValue<Vector2>().x;
        }
    }
 
    
}
