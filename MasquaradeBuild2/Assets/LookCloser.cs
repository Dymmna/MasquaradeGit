using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookCloser : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("CloserLook");

            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("DistantLook");
            }
        }
    }
}
