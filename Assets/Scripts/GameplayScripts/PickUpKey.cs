using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject keyOB;
    public GameObject invOB;
    public GameObject pickupKeyText;
    public AudioSource keySound;
    [SerializeField] private KeyCode interactKey = KeyCode.Mouse0;
    public bool inReach;

    public PickUpKey hoveredKey = null;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
        pickupKeyText.SetActive(false);
        invOB.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            hoveredKey.GetComponent<Outline>().enabled = true;
            inReach = true;
            pickupKeyText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            hoveredKey.GetComponent<Outline>().enabled = false;
            inReach = false;
            pickupKeyText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && (Input.GetKeyDown(interactKey)))
        {
            keyOB.SetActive(false);
            keySound.Play();
            invOB.SetActive(true);
            pickupKeyText.SetActive(false);
        }
    }
}
