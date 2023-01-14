using UnityEngine;

public class New_camera : MonoBehaviour
{
    public Transform target; // The character to follow
    public float smoothSpeed = 0.125f; // The speed at which the camera follows the character
    public Vector3 offset; // The distance between the camera and the character

   
        
        
        
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calculate the desired position of the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smoothly move the camera towards the desired position
        transform.position = smoothedPosition; // Update the camera's position

        // Make the camera look at the character and rotate it based on the character's rotation
        Quaternion desiredRotation = Quaternion.LookRotation(target.transform.forward);
        Quaternion smoothedRotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed);
        transform.rotation = smoothedRotation;
    }

        

        

    
}