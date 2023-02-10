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
    //update the UI for energy & score
    public void UpdatePelletText(PlayerInventory playerInventory)
    {
        pelletText.text = "Score : " + playerInventory.NumberOfPellets.ToString();
    }
    public void UpdateEnergyText(PlayerInventory playerInventory)
    {
        energyText.text = "Energy : " + playerInventory.Energy.ToString();
    }

}
