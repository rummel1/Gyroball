using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Debug.Log("rere");
    }
}
