using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory !=null )
        {
            playerInventory.PelletCollected();
            gameObject.SetActive(false);
        }
    }
}
