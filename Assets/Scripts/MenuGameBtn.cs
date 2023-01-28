using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameBtn : MonoBehaviour
{
    // Build number of scene to start when start btn is pressed
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }
}
