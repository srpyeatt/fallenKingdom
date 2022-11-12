using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionsController : MonoBehaviour
{
    // Initializes the GameObjects needed to run the functions
    [Header("Menu Objects")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject controlsMenu;
    public AudioMixer audioMixer;

    // Function to let the user go to the controlsMenu
    public void Controls() {
        controlsMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    // Function to let the user go back to the mainMenu
    public void Back() {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false); 
    }
    
    // Function to let the user set the volume for the game
    public void SetVolume(float volume) {
        audioMixer.SetFloat("volume", volume);
    }

    // Function to let the user decide if the game should be fullscreen or not
    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
}
