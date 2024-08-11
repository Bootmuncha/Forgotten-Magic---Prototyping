using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_TriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Manager_Dialogue>().InitiateDialogue(dialogue);
    }
}
