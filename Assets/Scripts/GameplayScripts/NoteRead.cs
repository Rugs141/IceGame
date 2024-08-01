using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRead : MonoBehaviour
{
    public GameObject player;
    public GameObject noteUI;
    //public GameObject hud;
    
    [SerializeField] private KeyCode interactKey = KeyCode.Mouse0;

    public GameObject pickUpText;

    public AudioSource pickUpSound;

    public bool inReach;

    public bool noteSoundPlayed = false;

    public NoteRead hoveredNote = null;
    private void Start()
    {
        noteUI.SetActive(false);
       // hud.SetActive(true);
       
        pickUpText.SetActive(false);

        inReach = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            hoveredNote.GetComponent<Outline>().enabled = true;
            inReach = true;
            pickUpText.SetActive(true);
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            hoveredNote.GetComponent<Outline>().enabled = true;
            inReach = true;
            pickUpText.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            hoveredNote.GetComponent<Outline>().enabled = false;
            inReach = false;
            pickUpText.SetActive(false);
            
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(interactKey) && inReach && !noteSoundPlayed)
        {
            noteUI.SetActive(true);
            pickUpText.SetActive(false);
            pickUpSound.Play();
            //hud.SetActive(false);
           
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;


            noteSoundPlayed = true;
        }
        
    }

    public void ExitButton()
    {
        
        noteUI.SetActive(false);
        //hud.SetActive(true);
       
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        noteSoundPlayed = false;
        

    }

}
