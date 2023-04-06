using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{

    public GameObject notebook;
    public bool notebookOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.X) & notebookOpen == false)
        {
            notebook.SetActive(true);
            notebookOpen = true;
            Time.timeScale = 0;
        }
       else if(Input.GetKeyDown(KeyCode.X) & notebookOpen == true)
        {
            notebook.SetActive(false);
            notebookOpen = false;
            Time.timeScale = 1;
        }
    }
}
