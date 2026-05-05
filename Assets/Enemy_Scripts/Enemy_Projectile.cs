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
        StartCoroutine(LifeTime());
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            playerBody.gameObject.GetComponent<Player_Movement>().TakeDamage(projectileDamage);
            Destroy(gameObject);
        }
    }

    public IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(projectileLifetime);
        Destroy(gameObject);
    }
    
}
