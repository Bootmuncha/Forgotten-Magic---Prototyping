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
    public bool canMagic;
    public bool magicCooldown;

    [SerializeField] GameObject spell1;
    [SerializeField] GameObject spell2;
    [SerializeField] GameObject spell3;
    [SerializeField] GameObject spell4;
    [SerializeField] GameObject spell5;
    [SerializeField] GameObject spell6;
    [SerializeField] GameObject spell7;
    [SerializeField] GameObject spell8;
    [SerializeField] GameObject spell9;
    /*[SerializeField]
    GameObject[] images;*/


    private void Start()
    {
        StartCoroutine(Cooldown());
    }

    void Update()
    {
        doMagic.onClick.AddListener(buttonPressed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    
    void buttonPressed()
    {
        if(canMagic == true)
        {
            if (leftMagic.currentMagicLeft == 0 && rightMagic.currentMagicRight == 0)
            {
                //image1.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell1);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 0 && rightMagic.currentMagicRight == 1)
            {
                //image2.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell2);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 0 && rightMagic.currentMagicRight == 2)
            {
                //image3.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell3);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 1 && rightMagic.currentMagicRight == 0)
            {
                //image4.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell4);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 1 && rightMagic.currentMagicRight == 1)
            {
                //image5.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell5);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 1 && rightMagic.currentMagicRight == 2)
            {
                //image6.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell6);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 2 && rightMagic.currentMagicRight == 0)
            {
                //image7.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell7);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 2 && rightMagic.currentMagicRight == 1)
            {
                //image8.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell8);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
            else if (leftMagic.currentMagicLeft == 2 && rightMagic.currentMagicRight == 2)
            {
                //image9.GetComponent<SpriteRenderer>().enabled = true;
                Instantiate(spell9);
                canMagic = false;
                StartCoroutine(Cooldown());
            }
        }   
    }

    public IEnumerator Cooldown()
    {
        yield return new WaitForEndOfFrame();
        canMagic = true;
    }
}
