using System.Timers;
using UnityEngine;

public class Player_Projectile : MonoBehaviour

{
    public GameObject projectile;
    public Transform firePoint;
    public float projectileSpeed;
    public float projectileDamage;
    public float projectileLife;


    public Player_Movement player;

    public void Spit()
    { 
        Vector2 fireDirection = new Vector2(player.playerRotation, player.playerRotation);
        GameObject spawnedProjectile = Instantiate(projectile, firePoint.position, Quaternion.identity);
        
        Rigidbody2D projectileRb = spawnedProjectile.GetComponent<Rigidbody2D>();
        if (projectileRb != null)
        {
            projectileRb.AddForce(fireDirection.normalized * projectileSpeed, ForceMode2D.Impulse);
        }

        Debug.Log("Spat");
    }
    
    
    
    
    
}
