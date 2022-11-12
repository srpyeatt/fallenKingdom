using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    // Initializes the GameObjects needed to run the functions
    [Header("Menu Objects")]
    public GameObject mainMenu;
    public GameObject optionsMenu;

    // Fuunction to let the user start the game at the designated scene
    public void StartGame() {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Game Start");
    }

    // Function to let the user go to the optionsMenu
    public void Options() {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    // Function to let the user exit the game
    public void Quit() {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
