using System.Collections;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class Player_Projectile : MonoBehaviour

{
    public GameObject projectile;
    public Transform firePoint;
    public float projectileSpeed;
    public float projectileDamage;
    public float projectileLife;

    public float cooldown;
    public bool canSpit = true;


    public Player_Movement player;
    

    IEnumerator CooldownRoutine(float cooldown)
    {
        canSpit = false;
        
        yield return new WaitForSeconds(cooldown);
        
        canSpit = true;
    }
    
    
    public void Spit()
    {
        if (canSpit == true)
        {
            Vector2 fireDirection = new Vector2(player.body.position.x,player.body.position.y);
            GameObject spawnedProjectile = Instantiate(projectile, firePoint.position, transform.rotation);
        
            Rigidbody2D projectileRb = spawnedProjectile.GetComponent<Rigidbody2D>();
            if (projectileRb != null)
            {
                projectileRb.AddForce(fireDirection * projectileSpeed, ForceMode2D.Impulse);
                Destroy(spawnedProjectile, projectileLife);
            }

            StartCoroutine(CooldownRoutine(cooldown));
        }
        
        
        Debug.Log("Spat");
    }
    
    
    
    
    
}
