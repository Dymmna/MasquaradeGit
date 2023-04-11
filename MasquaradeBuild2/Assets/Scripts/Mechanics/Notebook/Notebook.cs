using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{

    public GameObject notebook;
    public bool notebookOpen = false;

    //public PlayerController playerController;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");

        if (Input.GetKeyDown(KeyCode.X) & notebookOpen == false)
        {
            player.GetComponent<PlayerController>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
            player.GetComponent<Rigidbody2D>().simulated = false;

            notebook.SetActive(true);
            notebookOpen = true;
           // Time.timeScale = 0;
        }
       else if(Input.GetKeyDown(KeyCode.X) & notebookOpen == true)
        {
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<Animator>().enabled = true;
            player.GetComponent<Rigidbody2D>().simulated = true;
            notebook.SetActive(false);
            notebookOpen = false;
           // Time.timeScale = 1;
        }
    }
}
