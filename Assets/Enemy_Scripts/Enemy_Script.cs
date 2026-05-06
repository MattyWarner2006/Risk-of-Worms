using System.Collections;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public World_Physics playerState;
    public Player_Movement playerBody;
    public Enemy_Projectile enemyProjectileStats;
    public GameObject enemyProjectile;
    public Transform firePoint;
    public bool fireTimer = false;
    
    
    public Rigidbody2D enemyBody;
    public float enemyHealth;
    public float enemyMaxHealth;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && fireTimer == false)
        {
            fireTimer = true;
            StartCoroutine(ShotCooldown());
        }
    }
    public void FireProjectile()
    {
        Vector2 fireAtPlayer = new Vector2(playerBody.body.position.x, playerBody.body.position.y);
        GameObject spawnedProjectile = Instantiate(enemyProjectile, firePoint.position, Quaternion.identity);
        spawnedProjectile.SetActive(true);
        
        Rigidbody2D rb = spawnedProjectile.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
         rb.AddForce(fireAtPlayer * enemyProjectileStats.projectileSpeed, ForceMode2D.Impulse);   
        }
    }

    public void EnemyTakeDamage(float damage)
    {
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            playerBody.playerHealth += 1;
            if (playerBody.playerHealth >= playerBody.playerMaxHealth)
            {
                playerBody.playerHealth = playerBody.playerMaxHealth;
            }
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == playerBody.gameObject)
            EnemyTakeDamage(playerBody.playerDamage);
    }
    
    public IEnumerator ShotCooldown()
    {
        FireProjectile();
        yield return new WaitForSeconds(2);
        fireTimer = false;
    }
}

