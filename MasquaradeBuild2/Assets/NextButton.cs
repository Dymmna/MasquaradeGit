using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject b;
    private void OnMouseDown()
    {
        b.GetComponent<Switch>().Next();
    }
}
