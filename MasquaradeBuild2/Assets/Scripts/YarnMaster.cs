using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using System;

public class YarnMaster : MonoBehaviour
{
    DialogueRunner dialogueRunner;
    public int goodPoints = 0;
    public GameObject[] clues;

    //условия чтобы переключать сцены если нужно
    //if(goodPoints >= 5){
    //    SceneManager.LoadScene("название сцены с плохими штуками")
    //    }

    // Start is called before the first frame update
    void Start()
    {
        DialogueRunner dialogueRunner = FindObjectOfType<DialogueRunner>();

        dialogueRunner.AddCommandHandler("emptyNode", EmptyNode);
        dialogueRunner.AddCommandHandler("playNextNode", playNextNode);
        dialogueRunner.AddCommandHandler("recordObject", recordObject);
        dialogueRunner.AddCommandHandler("addPoints", addPoints);
    }

    [YarnCommand("emptyNode")]
    public void EmptyNode(string[] parameters)
    {
        NPC npcFound = FindNPC(parameters[0]);

        if (npcFound != null)
        {
            npcFound.talkToNode = "";
        }

    }

    [YarnCommand("playNextNode")]
    public void playNextNode(string[] parameters)
    {
        NPC foundNPC = FindNPC(parameters[0]);
        if (foundNPC != null)
        {
            foundNPC.playNext();
        }
    }

    //блокнот
    [YarnCommand("recordObject")]
    public void recordObject(string[] parameters)
    {
        int numberOfClue;
        int.TryParse(parameters[0], out numberOfClue);               
        clues[numberOfClue].SetActive(true);
    }

    //points for good ending
    [YarnCommand("addPoints")]
    public void addPoints(string[] parameters)
    {
        int points;
        int.TryParse(parameters[0], out points);
        goodPoints += points;
    }

    NPC FindNPC(string npcName)
    {
        foreach (NPC npc in FindObjectsOfType<NPC>())
        {
            if (npc.gameObject.name == npcName)
            {
                return npc;
            }
        }

        return null;
    }
}
