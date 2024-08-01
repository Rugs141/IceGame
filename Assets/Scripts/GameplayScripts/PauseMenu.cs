using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public static bool isPaused;

    public Behaviour disablePlayer;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        //disablePlayer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resumegame();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                
            }
            else
            {
                PauseGame();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        disablePlayer.enabled = false;
    }

    public void Resumegame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        disablePlayer.enabled = true;
    }

    public void Restartbutton()
    {
        SceneManager.LoadScene("Level 1");
        disablePlayer.enabled = true;

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
