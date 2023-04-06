using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Yarn.Unity;

/// attached to the non-player characters, and stores the name of the Yarn
/// node that should be run when you talk to them.
public class NPC : MonoBehaviour
{

    public string characterName = "";

    public string talkToNode = "";

    public string[] nextNode;

    private DialogueUI dialogueUI;

    [Header("Optional")]
    public YarnProgram scriptToLoad;

    void Start()
    {
        dialogueUI = FindObjectOfType<DialogueUI>();
        if (scriptToLoad != null)
        {
            Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            dialogueRunner.Add(scriptToLoad);
            //isFinished = true;
        }
    }

    public void Update()
    {

    }

    public void playNext()
    {
        for (int i = 0; i < nextNode.Length;)
        {
            talkToNode = nextNode[i];
            i++;
        }

    }

    public void endOfDialogue()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (talkToNode != "")
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, 2f);
    }
}
