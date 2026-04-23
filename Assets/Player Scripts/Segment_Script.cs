using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Segment_Script : MonoBehaviour
{
    public GameObject segmentAhead;

   


    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, segmentAhead.transform.position, Time.deltaTime * 30);
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, segmentAhead.transform.eulerAngles, Time.deltaTime * 30);
    }
}
