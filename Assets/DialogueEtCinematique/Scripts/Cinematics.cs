using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cinematics : MonoBehaviour
{
    public Camera firstPathCamera;
    public Camera secondPathCamera;
    public Camera thirdPathCamera;
    public Camera fourPathCamera;

    public TextMeshProUGUI txt;

    int i;
    int visibleratio;

    public string[] dialogues = {"dialogue 1", "dialogue 2", "dialogue 3", "dialogue 4"};

    private void Start()
    {
        i = 0;
        firstPathCamera.enabled = true;
        secondPathCamera.enabled = false;
        thirdPathCamera.enabled = false;
        fourPathCamera.enabled = false;

        firstPathCamera.enabled = true;
        firstPathCamera = Camera.main;
    }

    private void Update()
    {
        string actualDialogue = dialogues[i];
        int dialoguelenght = actualDialogue.Length;

        txt.text = actualDialogue.Substring(0, visibleratio/10);

        if (visibleratio <= dialoguelenght*10) {
            visibleratio += 5;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            actualDialogue = dialogues[i];
            dialoguelenght = actualDialogue.Length;
            visibleratio = 0;

            if (i == 0) {
                firstPathCamera.enabled = false;
                secondPathCamera.enabled = true;
                secondPathCamera = Camera.main;
            }

            if (i == 1) {
                secondPathCamera.enabled = false;
                thirdPathCamera.enabled = true;
                thirdPathCamera = Camera.main;
            }

            if (i == 2) {
                thirdPathCamera.enabled = false;
                fourPathCamera.enabled = true;
                fourPathCamera = Camera.main;
            }

            i += 1;
        }
    }
}
