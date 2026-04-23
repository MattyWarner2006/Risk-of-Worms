using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Screen_Wrapping : MonoBehaviour
{
    public float leftMargin = -100f;
    public float rightMargin = 100f;
    public float buffer = 1.0f;
    public float cameraZDistance = -10.0f;

void Awake()
    {
        leftMargin = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, cameraZDistance) ).x;
        rightMargin = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, cameraZDistance) ).x;
    }

    void Update()
{
        if (transform.position.x < leftMargin - buffer)
        {
            transform.position = new Vector3(rightMargin + buffer, transform.position.y,transform.position.z);
        }

        if (transform.position.x > rightMargin + buffer)
        {
            transform.position = new Vector3(leftMargin - buffer, transform.position.y, transform.position.z);
        }
    }
}
