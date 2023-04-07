using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueMixer : MonoBehaviour
{
    public bool addedA;
    public bool addedB;
    //первая пара зацепок

    [Header("First Set Of Clues")]
    public GameObject a;
    public GameObject b;
    public GameObject abclue;

    //вторая пара зацепок и т.д.

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(a.activeInHierarchy && b.activeInHierarchy)
        {
            Debug.Log("I can mix them...");
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
        if(addedA && addedB)
        {
            GenerateNewClue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coll");

        if(collision.gameObject.name == "obj1")
        {
            addedA = true;
        }

        if (collision.gameObject.name == "obj2")
        {
            addedB = true;
        }
    }

    public void GenerateNewClue()
    {
        Debug.Log("mixing");
        a.GetComponent<SpriteRenderer>().enabled = false;
        b.GetComponent<SpriteRenderer>().enabled = false;
        abclue.SetActive(true);
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<BoxCollider2D>().enabled = false;
    }
}
