using UnityEngine;
using UnityEngine.Tilemaps;

public class World_Physics : MonoBehaviour
{
    public Player_Movement player;
    public Segment_Script segment;
    public TilemapCollider2D tiles;


    public void GroundPhysics()
    {
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        player.GetComponent<Rigidbody2D>().linearDamping = 1.5f;
        segment.GetComponent<Rigidbody2D>().linearDamping = 1.5f;
        segment.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
       
    public void AirPhysics()
    {
        player.GetComponent<Rigidbody2D>().gravityScale = 2;
        player.GetComponent<Rigidbody2D>().linearDamping = 0.25f;
        segment.GetComponent<Rigidbody2D>().gravityScale = 2;

    }

    private void Update()
    {
        if(player.GetComponent<Rigidbody2D>().position.y >= 11)
        {
            AirPhysics();
            Debug.Log("set to air");
            Debug.Log("no drag");
        }
        if(player.GetComponent<Rigidbody2D>().position.y < 11)
        {
            GroundPhysics();
            Debug.Log("set to ground");
            Debug.Log("has drag");
        }
    }
}

