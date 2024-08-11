using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchFire_Collision : MonoBehaviour
{
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D colllider)
    {
        if (colllider.gameObject.tag == "FireTouch")
        {          
            Destroy(gameObject);
        }
    }
}
