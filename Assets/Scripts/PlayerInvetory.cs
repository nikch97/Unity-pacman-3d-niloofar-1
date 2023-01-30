using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfPellets { get; private set; }
   public UnityEvent<PlayerInventory> OnPelletCollected;

    public void PelletCollected()
    {
        NumberOfPellets=NumberOfPellets+5;
        OnPelletCollected.Invoke(this);
    }
}
