using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomTrigger : MonoBehaviour
{

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    private bool activated;
    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController pc = collision.GetComponent<PlayerController>();
        if (!activated && pc != null && Mathf.Abs(transform.position.y - collision.transform.position.y) < 1)
        {
            onTriggerEnter.Invoke();
            activated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController pc = collision.GetComponent<PlayerController>();
        if (activated && pc != null)
        {
            onTriggerExit.Invoke();
            activated = false;
        }
    }
}
