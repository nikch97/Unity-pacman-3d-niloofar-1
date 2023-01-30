using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPellet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.BadPelletCollected();
            gameObject.SetActive(false);
        }
    }
}
