using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPellet : MonoBehaviour
{
    AudioSource waka;

    public void Start()
    {
        waka = GetComponent<AudioSource>();
    }
    //destroy the pellet after collision and play a sound
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                playerInventory.BadPelletCollected();
                //gameObject.SetActive(false);

            }

            Renderer[] allRenderers = gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer c in allRenderers) c.enabled = false;
            Collider[] allColliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider c in allColliders) c.enabled = false;

            StartCoroutine(PlayAndDestroy(waka.clip.length));
        }
    }

    private IEnumerator PlayAndDestroy(float waitTime)
    {
        waka.Play();
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
