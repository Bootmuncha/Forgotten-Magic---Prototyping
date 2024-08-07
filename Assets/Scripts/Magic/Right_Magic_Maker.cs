using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Right_Magic_Maker : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    public int currentMagicRight; 
  
    
    public void GetDropdownValue()
    {
        int pickedEntryIndex = dropdown.value;
        string selectedOption = dropdown.options[pickedEntryIndex].text;
        currentMagicRight = dropdown.value;
        /*Debug.Log(selectedOption);
        Debug.Log(currentMagicLeft);*/

    }
}
