using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GeneralTrigger : MonoBehaviour
{
    [SerializeField] bool destroyOnTriggerEnter;
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            onTriggerEnter.Invoke();
      
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            onTriggerExit.Invoke();
    }
}
