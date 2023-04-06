using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public GameObject scanner;
    private bool scanning = false;

    private void Update()
    {
        StartScanner();
    }



    private void StartScanner()
    {
        if (Input.GetKeyDown(KeyCode.E) & scanning == false)
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
