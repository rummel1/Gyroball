using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    public Transform chracter;
    public Rigidbody rb;
    private Vector3 spawnPoint;
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (chracter.transform.position.y < -20f)
        {
            chracter.position = spawnPoint;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("CheckPoint"))
        {
            spawnPoint = other.transform.position;
            
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            spawn();
            rb.velocity=Vector3.zero;
            rb.angularVelocity=Vector3.zero;
            rb.Sleep();
            
            
            

        }
        
    }
    private void spawn()
    {
        chracter.position = spawnPoint;
    }
}
