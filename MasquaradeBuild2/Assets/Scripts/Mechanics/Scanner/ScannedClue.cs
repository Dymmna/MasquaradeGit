using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedClue : MonoBehaviour
{

    private Animator animator;
    public GameObject yarnMaster;

    public int clueCount;
    public GameObject cluesInNotebook;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        yarnMaster = GameObject.Find("YarnMaster");
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Scanner"))
        {
          
            StartCoroutine(ScanClue());
        }
           
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Scanner"))
        {

            Debug.Log("NotScan");
            animator.SetTrigger("NotScanned");


            //возможно ли?
            //yarnMaster.GetComponent<YarnMaster>().recordObject();

        }
    }

    IEnumerator ScanClue()
    {
        yield return new WaitForSeconds(2);

        Debug.Log("putScanToInventory");
        cluesInNotebook.SetActive(true);
        animator.SetTrigger("NotScanned");
        Destroy(gameObject);
               
        

           
    }
}
