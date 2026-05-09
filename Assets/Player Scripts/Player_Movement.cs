using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Timeline;

public class Player_Movement : MonoBehaviour
{
    public InputActionReference movementInput;
    public InputActionReference sprintInput;
    public BoxCollider2D hitBox;
    public Rigidbody2D body;
    public GameObject retryScreenUi;

    public float score;
    public float playerHealth;
    public float playerMaxHealth;
    public float playerSpeed;
    public float playerMaxSpeed;
    public float playerRotation;
    public float playerRotationSpeed = 1;
    public float playerDamage = 1;

    //Take damage from enemies + kill player when health below 0
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            retryScreenUi.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    void Start()
    {
        playerHealth = playerMaxHealth;
    }
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
                if (playerSpeed >= playerMaxSpeed)
                {
                    playerSpeed = 60;
                }
                
                break;
            case false:
                playerSpeed = 20;
                break;
        }
    }

    private void FixedUpdate()
    {
        //give player constant movement
        body.AddForce(transform.up * playerSpeed);
    }
    
}
