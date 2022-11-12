using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseController : MonoBehaviour
{
    // Initializes the GameObjects needed to run the functions
    public GameObject playerUI;
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    private CursorLockMode cursorMode;

    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            Pause();
        } 
    }

    void Pause() {
        TimeStop(true);
        playerUI.SetActive(false);
        pauseMenu.SetActive(true);
    }

    void TimeStop(bool value) {
        if (value == true) {
            Time.timeScale = 0.1f;
        } else if (value == false) {
            Time.timeScale = 1.0f;
        }
    }

    public void Resume() {
        TimeStop(false);
        playerUI.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void Options() {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
