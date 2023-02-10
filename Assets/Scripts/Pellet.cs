using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class Pellets : MonoBehaviour
{
    AudioSource eatFruit;

    public void Start()
    {
        eatFruit = GetComponent<AudioSource>();
    }
    //destroy the pellet after collision and play a sound
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                playerInventory.PelletCollected();
                //gameObject.SetActive(false);

            }

            Renderer[] allRenderers = gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer c in allRenderers) c.enabled = false;
            Collider[] allColliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider c in allColliders) c.enabled = false;

            StartCoroutine(PlayAndDestroy(eatFruit.clip.length));
        }
    }

    private IEnumerator PlayAndDestroy(float waitTime)
    {
        eatFruit.Play();
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }

}
