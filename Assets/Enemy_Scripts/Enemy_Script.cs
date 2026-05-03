using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public World_Physics playerState;
    public Enemy_Projectile enemyProjectile;
    
    
    public Rigidbody2D enemyBody;
    public float enemyHealth;
    public float enemyMaxHealth;
    public float enemyDamage;
    public float enemySpeed;

    public Transform[] enemyWalkPoints;
    public Transform target;

    void Start()
    {
        target = enemyWalkPoints[0];
        enemyHealth = enemyMaxHealth;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,target.position,enemySpeed * Time.deltaTime);
        if (enemyBody.position.x >= target.position.x)
        {
            ChangeTarget();
        }
    }
    
    private void ChangeTarget()
    {
        if (transform.position.x == enemyWalkPoints[0].position.x)
        {
            target = enemyWalkPoints[1];
        }
        
        else if (transform.position.x == enemyWalkPoints[1].position.x)
        {
            target = enemyWalkPoints[0];
        }
    }

    public void ShootPlayer()
    {
        if (playerState.isBelowGround == true)
        {
            Debug.Log("Player is below ground");
        }

        if (playerState.isBelowGround == false)
        {
            FireProjectile();
        }
    }

    public void FireProjectile()
    {
        
    }
}

