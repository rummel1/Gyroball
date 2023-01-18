using UnityEngine;

public class ForwardBackMovement : MonoBehaviour
{
    public float speed = 1;
    public float distance = 5;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.Sin(Time.time * speed) * distance, 0, 0);
    }
}