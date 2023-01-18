using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball_Controller : MonoBehaviour
{
    public Rigidbody rb;

    public int speed;
    
    public Canvas WinGame;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(horizontal, 0, vertical);
        rb.AddForce(vector*speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("level2"))
        {
            SceneManager.LoadScene("Level02");
        }

       if (other.gameObject.CompareTag("Finish"))
       {
           WinGame.gameObject.SetActive(true);
       }
           
    }

    
}
