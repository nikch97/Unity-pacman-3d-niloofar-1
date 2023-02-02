using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    //public AudioSource eatFruit;

    private void OnTriggerEnter(Collider other)
    {
        
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        AudioSource eatFruit = other.GetComponent<AudioSource>();
        Debug.Log(eatFruit);

        if(playerInventory !=null )
        {
            playerInventory.PelletCollected();
            eatFruit.Play();
            gameObject.SetActive(false);
            
        }
    }
}
