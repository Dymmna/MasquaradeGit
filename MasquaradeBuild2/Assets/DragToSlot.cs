using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToSlot : MonoBehaviour
{
    private Vector2 offset;
    private Vector3 position;

    private Vector3 startPosition;

    private bool drag;

    private bool onSlot;
    public GameObject slot;
    public string slotName;


    private void Start()
    {
        slot = GameObject.Find(slotName);
        transform.position = new Vector3(slot.transform.position.x, slot.transform.position.y, slot.transform.position.z);
    }
    private void OnMouseDrag()
    {

        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position + (Vector3)offset;

        //  float distance = Vector2.Distance(transform.position, detailPosition.position);


    }

    private void OnMouseDown()
    {
        //if(onSlot == false)
        //{
        //position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //position.z = 0;
        //offset = transform.position - position;
        //drag = true;
        //}
        //else if (onSlot == true)
        //{
        //    Debug.Log("onslot");
        //    position = slot.transform.position;
        //}

       

      
    }

    private void OnMouseUp()
    {
        drag = false;
        transform.position = new Vector3(slot.transform.position.x, slot.transform.position.y, slot.transform.position.z);
        //if (canDrop && !placeMe)
        //{
        //    transform.position = detailPosition.position;
        //    placeMe = true;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        //if(collision.CompareTag("Slot"))
        //{
        //    Debug.Log("trigger");
        //    onSlot = true;
            
        //}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.CompareTag("Slot"))
        //{
        //    onSlot = false;
            
        //}
    }
}
