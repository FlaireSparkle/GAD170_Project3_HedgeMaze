using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadFirstScene()
    {
        //start button should load the Maze scene (this will load the scene from the build index, if any issues check there first)
        SceneManager.LoadScene(1);  
    }

   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
