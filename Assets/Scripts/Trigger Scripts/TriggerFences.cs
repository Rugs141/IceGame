using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFences : MonoBehaviour
{
    [SerializeField] private Animator fenceAnimator;

    public AudioSource fenceBreakSound;

    public GameObject scareCrows;
    public GameObject scarewSpawnTrigger;

    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        {
            fenceAnimator.SetBool("open", true);
            fenceBreakSound.Play();
            scareCrows.SetActive(false);
            scarewSpawnTrigger.SetActive(true);


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
