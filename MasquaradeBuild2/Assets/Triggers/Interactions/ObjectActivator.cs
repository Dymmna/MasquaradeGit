using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ObjectActivator : MonoBehaviour
{
    bool yuraOne = false;
    InMemoryVariableStorage variables;
    private void Start()
    {
        variables = FindObjectOfType<InMemoryVariableStorage>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        yuraOne = variables.GetValue("$npc_value").AsBool;
        if (!yuraOne)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
