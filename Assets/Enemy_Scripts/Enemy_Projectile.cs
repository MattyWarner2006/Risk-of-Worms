using UnityEngine;
using System.Collections;

public class Enemy_Projectile : MonoBehaviour
{
    public Player_Movement playerBody;
    public GameObject projectile;
    public float projectileSpeed;
    public float projectileDamage;
    public float projectileLifetime;


    private void Awake()
    {
        //when projectile is spawned, starts lifetime timer
        StartCoroutine(LifeTime());
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        //projectile deals damage to the player on hit and gets destroyed
        if (player.CompareTag("Player"))
        {
            playerBody.gameObject.GetComponent<Player_Movement>().TakeDamage(projectileDamage);
            Destroy(gameObject);
        }
    }

    public IEnumerator LifeTime()
    {
        //after set value of time, destroy projectile
        yield return new WaitForSeconds(projectileLifetime);
        Destroy(gameObject);
    }
    
}
