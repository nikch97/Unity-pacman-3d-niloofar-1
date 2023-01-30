using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI pelletText;
    private TextMeshProUGUI energyText;
    // Start is called before the first frame update
    void Start()
    {
        pelletText= GetComponent<TextMeshProUGUI>();
        energyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePelletText(PlayerInventory playerInventory)
    {
        pelletText.text = "Score : " + playerInventory.NumberOfPellets.ToString();
        energyText.text = "Enery : " + playerInventory.Energy.ToString();
    }

   
}
