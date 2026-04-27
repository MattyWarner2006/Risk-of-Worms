using UnityEngine;
using UnityEngine.Tilemaps;

public class World_Physics : MonoBehaviour
{
    public Player_Movement player;
    public Segment_Script segment;
    public TilemapCollider2D tiles;


    public void GroundPhysics()
    {
        //when player is underground - simulate digging
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        player.GetComponent<Rigidbody2D>().linearDamping = 1.5f;
        segment.GetComponent<Rigidbody2D>().linearDamping = 1.5f;
        segment.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
       
    public void AirPhysics()
    {
        //when player is airborne - simulate gravity and aerodynamics
        player.GetComponent<Rigidbody2D>().gravityScale = 2;
        player.GetComponent<Rigidbody2D>().linearDamping = 0.25f;
        segment.GetComponent<Rigidbody2D>().gravityScale = 2;

    }

    private void Update()
    {
        //check y of player, then set corresponding values
        if(player.GetComponent<Rigidbody2D>().position.y >= 11)
        {
            AirPhysics();
        }
        if(player.GetComponent<Rigidbody2D>().position.y < 11)
        {
            GroundPhysics();
        }
    }
}

