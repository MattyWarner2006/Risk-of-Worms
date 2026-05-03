using System.Collections;
using UnityEngine;

public class Enemy_Projectile : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed;
    public float projectileDamage;
    public float projectileLifetime;
    public float cooldown;

    public IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(ShotCooldown());
    }

    private void Awake()
    {
        StartCoroutine(ShotCooldown());
    }

    private void OnTriggerEnter2D(Collider2D playerBody)
    {
        playerBody.gameObject.GetComponent<Player_Movement>().TakeDamage(projectileDamage);
    }
}
