using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameBtn : MonoBehaviour
{
    // Build number of scene to start when start btn is pressed
    public int pacMan=1;
    public int endGame = 3;
    // handling the buttons & other scenes
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(pacMan);
    }

    public void QuitGame()
    {
       // UnityEditor.EditorApplication.isPlaying = false;
        //Debug.Log("Quit the game!");
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                SceneManager.LoadScene(endGame);

            }

           
        }
    }
}
