using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDetector : MonoBehaviour
{
    public bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("here");
            inTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
}

