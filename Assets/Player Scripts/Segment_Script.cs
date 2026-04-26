using UnityEngine;

public class Segment_Script : MonoBehaviour
{
    public GameObject segmentAhead;
    

    private void Update()
    {
        //move segment to required position + how fast it moves
        transform.position = Vector3.Lerp(transform.position, segmentAhead.transform.position, Time.deltaTime * 30);
        transform.rotation = Quaternion.Lerp(transform.rotation, segmentAhead.transform.rotation, Time.deltaTime * 20);
    }
}
