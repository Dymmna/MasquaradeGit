using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevPage : MonoBehaviour
{
    public GameObject b;
    private void OnMouseDown()
    {
        if (b.GetComponent<Switch>().index > 0)
        {
            b.GetComponent<Switch>().Previous();
        }
       
    }
}
