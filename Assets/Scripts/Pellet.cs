using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    //public AudioSource eatFruit;

    private void OnTriggerEnter(Collider other)
    {
       
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory !=null )
        {
           // eatFruit.Play();
            playerInventory.PelletCollected();
            gameObject.SetActive(false);
            
        }
    }
}
