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

    void Start()
    {
        notebook = GameObject.Find("Notebook new");
    }

    private void OnMouseDown()
    {
        notebook.SetActive(false);

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
