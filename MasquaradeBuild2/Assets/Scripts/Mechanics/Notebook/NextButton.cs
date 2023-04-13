using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject b;
    private void OnMouseDown()
    {
        if (b.GetComponent<Switch>().index <3)
        {
            b.GetComponent<Switch>().Next();
        }
       
    }
}
