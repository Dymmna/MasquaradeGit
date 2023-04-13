using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public GameObject scanner;
    private bool scanning = false;

    private bool nearNPC;

    private void Update()
    {
        StartScanner();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<NPC>() != null)
        {
            //Debug.Log("no yarn");
            nearNPC = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<NPC>() != null)
        {
            
            nearNPC = false ;

        }
    }



    private void StartScanner()
    {
        if (Input.GetKeyDown(KeyCode.E) & scanning == false & nearNPC == false)
        {
            scanner.SetActive(true);
            scanning = true;
            StartCoroutine(ScannerTimer());
        }
    }

    IEnumerator ScannerTimer()
    {
        yield return new WaitForSeconds(3);
        scanner.SetActive(false);
        scanning = false;
    }


}
