using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public int gameOver = 2;
    public int NumberOfPellets { get; private set; }
    public int Energy { get;  set; } = 5;

   public UnityEvent<PlayerInventory> OnPelletCollected;

    public void Start()
    {
     
    }

    public void PelletCollected()
    {
        NumberOfPellets++;
        Energy = Energy+5;
        OnPelletCollected.Invoke(this);
    }

    //public void PowPelletCollected()
    //{
    //    Energy = Energy + 20;
    //    OnPelletCollected.Invoke(this);
    //}

    public void BadPelletCollected()
    {
        Energy = Energy-5;
        OnPelletCollected.Invoke(this);
        if (Energy <= 0)
        {
            EndGame();
        }
    }
    public void GhostCollide()
    {
        Energy = Energy - 2;
        OnPelletCollected.Invoke(this);
        if (Energy <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(gameOver);
    }
}
