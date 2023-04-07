using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastTravel : MonoBehaviour
{
    public string sceneName;
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if(sceneName != SceneManager.GetActiveScene().name)
        {

            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene(sceneName);

        }


       
    }
}
