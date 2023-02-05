using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public int gameOver = 2;
    public int NumberOfPellets { get; private set; }
    public int Energy { get; private set; } = 5;
 
   public UnityEvent<PlayerInventory> OnPelletCollected;

    public void PelletCollected()
    {
        NumberOfPellets++;
        Energy = Energy+5;
        OnPelletCollected.Invoke(this);
    }

    public void BadPelletCollected()
    {
        Energy = Energy-5;
        OnPelletCollected.Invoke(this);
        if (Energy == 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(gameOver);
    }
}
