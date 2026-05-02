using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Attacks : MonoBehaviour
{
  public World_Physics worldPhysics;
  public CircleCollider2D biteHitbox;
  public Player_Projectile projectile;


  private void Start()
  {
    biteHitbox.enabled = false;
  }

  public void Attack1(InputAction.CallbackContext biteAttack)
  {
    if (biteAttack.action.triggered)
    {
        biteHitbox.enabled = true;
    }

    if (!biteAttack.action.triggered)
    {
      biteHitbox.enabled = false;
    }
    
  }

  public void Attack2(InputAction.CallbackContext spitAttack)
  {
    if (spitAttack.action.triggered)
    {
      if (worldPhysics.isBelowGround == false)
      {
        projectile.Spit();
      }
    }
  }
}
