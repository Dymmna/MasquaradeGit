using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placePosition : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform detailPosition;
    public bool placeMe = false;

    private Color activeColor = new Color(0.3f, 0, 0);
    private Vector2 offset;
    private Vector3 position;

    private SpriteRenderer sr;
    private bool canDrop;

    private bool drag;

    //public AudioSource wood;
    //public AudioSource woodDown;

    private void Start()
    {
        activeColor = attatchDetail._activeColor;
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (drag && !canDrop && !placeMe) sr.color = activeColor;
        else sr.color = Color.white;
        
    }

    private void OnMouseDrag()
    {
        if (!placeMe)
        {
            position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            transform.position = position + (Vector3)offset;

            float distance = Vector2.Distance(transform.position, detailPosition.position);
            canDrop = distance < 1f;
        }     

    }

    private void OnMouseDown()
    {
        //wood.Play();
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        offset = transform.position - position;
        drag = true;
    }

    private void OnMouseUp()
    {
        
        drag = false;
        if (canDrop && !placeMe)
        {
            transform.position = detailPosition.position;
            placeMe = true;
           // woodDown.Play();
        }
    }
}
