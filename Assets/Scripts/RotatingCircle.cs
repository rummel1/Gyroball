using UnityEngine;

public class RotatingCircle : MonoBehaviour
{
    public float radius = 1;
    public int segments = 36;
    public float rotationSpeed = 10;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Vector3 center = transform.position;
        Gizmos.color = Color.yellow;
        for (int i = 0; i < segments; i++)
        {
            float angle = i * Mathf.PI * 2 / segments;
            Vector3 pos = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
            Gizmos.DrawLine(center + pos, center + pos + new Vector3(0, 0.2f, 0));
        }
    }
}