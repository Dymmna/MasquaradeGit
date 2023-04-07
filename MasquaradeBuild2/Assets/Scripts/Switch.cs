using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject[] spreads;
    public GameObject[] buttons;

    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= 4)
            index = 4;
        if (index < 0)
            index = 0;

        if(index == 0)
        {
            spreads[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;
        StartCoroutine(ChangePages());

    }

    public void Previous()
    {
        index -= 1;
        StartCoroutine(ChangePages());
    }

    IEnumerator ChangePages()
    {    
        for (int i = 0; i < spreads.Length; i++)
        {        
            //spreads[i].gameObject.GetComponent<Animator>().enabled = true;
            //spreads[i].gameObject.GetComponent<Animator>().Play("animation fade out name here");  
            //yield return new WaitForSeconds(1f);
            spreads[i].gameObject.SetActive(false);
            spreads[index].gameObject.SetActive(true);
            //spreads[index].gameObject.GetComponent<Animator>().Play("animation with fade in name here");  
        }
        yield return null;
    }
}
