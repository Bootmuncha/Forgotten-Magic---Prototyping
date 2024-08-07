using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Left_Magic_Maker : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    public int currentMagicLeft; 
  
    
    public void GetDropdownValue()
    {
        int pickedEntryIndex = dropdown.value;
        string selectedOption = dropdown.options[pickedEntryIndex].text;
        currentMagicLeft = dropdown.value;
        /*Debug.Log(selectedOption);
        Debug.Log(currentMagicLeft);*/

    }
}
