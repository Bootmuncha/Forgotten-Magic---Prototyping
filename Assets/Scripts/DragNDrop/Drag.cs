using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 mouseOffset;

    private Vector3 mouseWorldPosition() 
    { 
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown()
    {
        mouseOffset = gameObject.transform.position - mouseWorldPosition(); 
    }

    private void OnMouseDrag()
    {
        transform.position =mouseWorldPosition() + mouseOffset;
    }
}
