using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotScaned : MonoBehaviour
{
    private SpriteRenderer sr;

    public float timeToFade = 5;
   
    public bool isScanned = false;
    public bool noScan;

    private float alpha;
    private Color color;
    // Start is called before the first frame update
    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isScanned)
        {
            FadeIn();
            //isScanned = false;
            //StartCoroutine(newFadeIn());
        }
        if (noScan && !isScanned) 
        {
            FadeOut();
            //StartCoroutine(newFadeOut());
            //isScanned = false;
        }
      
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Scanner"))
        {
            // sr.color = new Color(1, 1, 1, 100);
            Debug.Log("Scan");
            isScanned = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Scanner"))
        {
            // sr.color = new Color(1, 1, 1, 100);
            Debug.Log("NotScan");
            noScan = true;
            //isScanned = false;
        }
    }

    IEnumerator newFadeIn()
    {
        yield return null;
        Color color = transform.GetComponent<SpriteRenderer>().color;
        transform.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, timeToFade * Time.deltaTime);
    }
    IEnumerator newFadeOut()
    {
        yield return null;
        Color color = transform.GetComponent<SpriteRenderer>().color;
        transform.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, timeToFade * Time.deltaTime);
    }


    private void FadeIn()
    {
        Color color = transform.GetComponent<SpriteRenderer>().color;
        transform.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, timeToFade * Time.deltaTime);
        if(color.a == 255)
        {
            isScanned = false;
        }

    }

    private void FadeOut()
    {
        Color color = transform.GetComponent<SpriteRenderer>().color;
        transform.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, timeToFade * Time.deltaTime);
    }

    


}
