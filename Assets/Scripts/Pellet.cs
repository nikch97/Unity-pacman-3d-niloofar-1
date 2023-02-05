using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class Pellets : MonoBehaviour
{
    public AudioSource eatFruit;

    public void Start()
    {
        eatFruit = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        eatFruit.Play();
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory !=null )
        {
            playerInventory.PelletCollected();
            gameObject.SetActive(false);
            
        }
    }
}
