using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfPellets { get; private set; }
   public int Energy { get; private set; }
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
    }
}
