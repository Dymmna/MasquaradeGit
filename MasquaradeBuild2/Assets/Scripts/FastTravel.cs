using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastTravel : MonoBehaviour
{
    public string sceneName;
    [Header("objects to delete")]
    public GameObject[] toDelete;
    public GameObject notebook;
    public GameObject notebookHolder;
    public Notebook notebookScript;

    void Start()
    {
        notebook = GameObject.Find("Notebook new");
        notebookHolder = GameObject.Find("NotebookHolder");
        notebookScript = notebookHolder.GetComponent<Notebook>();
    }

    private void Update()
    {
        notebook = GameObject.Find("Notebook new");
        
    }

    private void OnMouseDown()
    {
        notebook.SetActive(false);
        notebookScript.notebookOpen = false;


        if (sceneName != SceneManager.GetActiveScene().name)
        {
                
            if(sceneName == "Test_Scene")
            {
                foreach (GameObject delete in toDelete)
                {
                    Destroy(delete);
                }
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                SceneManager.LoadScene(sceneName);
            }
        }


       
    }
}
