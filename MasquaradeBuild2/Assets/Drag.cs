using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //public Transform detailPosition;

    private Vector2 offset;
    private Vector3 position;

    private bool drag;

    private void OnMouseDrag()
    {
        
            position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            transform.position = position + (Vector3)offset;

          //  float distance = Vector2.Distance(transform.position, detailPosition.position);
           
       
    }

    private void OnMouseDown()
    {
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        offset = transform.position - position;
        drag = true;
    }

    private void OnMouseUp()
    {
        drag = false;
        //if (canDrop && !placeMe)
        //{
        //    transform.position = detailPosition.position;
        //    placeMe = true;
        //}
    }
}
