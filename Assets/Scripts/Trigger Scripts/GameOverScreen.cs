using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Behaviour disablePlayer;
    
    [SerializeField] private Animator Animator;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator.SetBool("fadein", true);
            // disable player script
            disablePlayer.enabled = false;
            //enabled cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

       


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }


    }

    public void Restartbutton()
    {
        SceneManager.LoadScene("Level 1");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
