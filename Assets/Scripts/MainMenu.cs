using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    // Code for Start button
    // Loads the next scene in queue in the build settings of the Unity project
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Code for Quit button
    // Sends an Application.Quit **THIS WILL NOT WORK IN THE EDITOR ONLY IN A BUILT CLIENT**
    // Throws a debug into console to show that the game attempted to close
    public void QuitGame()
    {
    Debug.Log("ATTEMPTED TO QUIT GAME");
    Application.Quit();
    }
}
