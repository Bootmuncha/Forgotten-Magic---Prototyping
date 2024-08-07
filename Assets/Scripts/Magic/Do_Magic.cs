using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Do_Magic : MonoBehaviour
{
    public Right_Magic_Maker rightMagic;
    public Left_Magic_Maker leftMagic;
    public Button doMagic;

    [SerializeField] GameObject image1;
    [SerializeField] GameObject image2;
    [SerializeField] GameObject image3;
    [SerializeField] GameObject image4;
    [SerializeField] GameObject image5;
    [SerializeField] GameObject image6;
    [SerializeField] GameObject image7;
    [SerializeField] GameObject image8;
    [SerializeField] GameObject image9;
    /*[SerializeField]
    GameObject[] images;*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        doMagic.onClick.AddListener(buttonPressed); 
       
    }
    
    void buttonPressed()
    {
        image1.GetComponent<SpriteRenderer>().enabled = false;
        image2.GetComponent<SpriteRenderer>().enabled = false;
        image3.GetComponent<SpriteRenderer>().enabled = false;
        image4.GetComponent<SpriteRenderer>().enabled = false;
        image5.GetComponent<SpriteRenderer>().enabled = false;
        image6.GetComponent<SpriteRenderer>().enabled = false;
        image7.GetComponent<SpriteRenderer>().enabled = false;
        image8.GetComponent<SpriteRenderer>().enabled = false;
        image9.GetComponent<SpriteRenderer>().enabled = false;
        
        if (rightMagic.currentMagicRight == 0 && leftMagic.currentMagicLeft == 0)
        {
            image1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 0 && leftMagic.currentMagicLeft == 1)
        {
            image2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 0 && leftMagic.currentMagicLeft == 2)
        {
            image3.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 1 && leftMagic.currentMagicLeft == 0)
        {
            image4.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 1 && leftMagic.currentMagicLeft == 1)
        {
            image5.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 1 && leftMagic.currentMagicLeft == 2)
        {
            image6.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 2 && leftMagic.currentMagicLeft == 0)
        {
            image7.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 2 && leftMagic.currentMagicLeft == 1)
        {
            image8.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (rightMagic.currentMagicRight == 2 && leftMagic.currentMagicLeft == 2)
        {
            image9.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
