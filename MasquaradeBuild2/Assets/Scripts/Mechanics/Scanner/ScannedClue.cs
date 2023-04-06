using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedClue : MonoBehaviour
{

    private Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Scanner"))
        {
            Debug.Log("Scan");



            //animator.SetBool("IsScanned", true);
            animator.SetTrigger("Scanned");

        }
    }

     private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Scanner"))
        {
            
            Debug.Log("NotScan");
            animator.SetTrigger("NotScanned");
            //animator.SetBool("IsScanned", false);

        }
    }
}
