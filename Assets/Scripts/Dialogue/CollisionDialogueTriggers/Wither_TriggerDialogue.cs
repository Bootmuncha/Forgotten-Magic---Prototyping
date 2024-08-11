using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wither_Trigger_Dialogue : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnTriggerEnter2D(Collider2D colllider)
    {
        Debug.Log("Hit" + colllider.name);
        if (colllider.gameObject.tag == "PlayerWither")
        {
            FindObjectOfType<Manager_Dialogue>().InitiateDialogue(dialogue);
            //Destroy(gameObject);
        }
    }
}
