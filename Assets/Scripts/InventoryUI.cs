using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI pelletText;
    // Start is called before the first frame update
    void Start()
    {
        pelletText= GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePelletText(PlayerInventory playerInventory)
    {
        pelletText.text = "Score : " + playerInventory.NumberOfPellets.ToString();
    }

   
}
