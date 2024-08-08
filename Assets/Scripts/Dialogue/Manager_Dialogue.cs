using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager_Dialogue : MonoBehaviour
{
    public TextMeshProUGUI locationText;
    public TextMeshProUGUI descriptionText;
    
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void InitiateDialogue(Dialogue dialogue)
    {
        //Debug.Log("Describing " + dialogue.location);
        locationText.text = dialogue.location;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences) 
            { 
            sentences.Enqueue(sentence); 
            }
        
        DisplayNextSentence();


    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        descriptionText.text = sentence;
              
    }

    void EndDialogue()
    {
        Debug.Log("Conversation Over");
    }
     
}
