using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTreeFalls: MonoBehaviour
{
    [SerializeField] private Animator treeAnimator;

    public AudioSource treeFallSound;

    [SerializeField] bool destroyOnTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
       
        {
            treeAnimator.SetBool("Fall", true);
            treeFallSound.Play();
            
        }
          
           
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
           
        
    }
}
