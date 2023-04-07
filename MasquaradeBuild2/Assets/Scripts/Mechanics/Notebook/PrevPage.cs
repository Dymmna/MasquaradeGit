using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevPage : MonoBehaviour
{
    public GameObject b;
    private void OnMouseDown()
    {
        b.GetComponent<Switch>().Previous();
    }
}
