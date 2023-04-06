using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text textBox;
    public AudioClip typingClip;
    public AudioSourceGroup audioSourceGroup;

    private DialogueVertexAnimator dialogueVertexAnimator;
    void Awake() {
        dialogueVertexAnimator = new DialogueVertexAnimator(textBox, audioSourceGroup);
    }

    private Coroutine typeRoutine = null;
    public void PlayDialogue(string message) {
        textBox.text = " ";
        this.EnsureCoroutineStopped(ref typeRoutine);
        dialogueVertexAnimator.textAnimating = false;
        List<DialogueCommand> commands = DialogueUtility.ProcessInputString(message, out string totalTextMessage);
        typeRoutine = StartCoroutine(dialogueVertexAnimator.AnimateTextIn(commands, totalTextMessage, typingClip, null));
    }

}
