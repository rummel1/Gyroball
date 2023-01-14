using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 2f;
    public float leftLimit = -2f;
    public float rightLimit = 2f;

    private bool movingRight = true;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (movingRight)
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
            if (transform.position.x >= rightLimit)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            if (transform.position.x <= leftLimit)
            {
                movingRight = true;
            }
        }
    }
}