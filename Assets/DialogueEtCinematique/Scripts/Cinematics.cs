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

    public bool enableCinematics;

    public int delayInterDialogues;

    public GameObject nextCinematic; 

    int actualDelay;

    int i;
    int visibleratio;

    public string[] dialogues = {"dialogue 1", "dialogue 2", "dialogue 3", "dialogue 4"};

    string actualDialogue;
    int dialoguelenght;

    private void Start()
    {
        i = 0;
        actualDelay = 0;
        if (enableCinematics == true) {
            firstPathCamera.enabled = true;
            //firstPathCamera = Camera.main;
        }
        secondPathCamera.enabled = false;
        thirdPathCamera.enabled = false;
        fourPathCamera.enabled = false;
    }

    private void changeCinematicScene() {
        actualDialogue = dialogues[i];
        dialoguelenght = actualDialogue.Length;
        visibleratio = 0;

        if (i == 0) {
            firstPathCamera.enabled = false;
            secondPathCamera.enabled = true;
        }

        if (i == 1) {
            secondPathCamera.enabled = false;
            thirdPathCamera.enabled = true;
        }

        if (i == 2) {
            thirdPathCamera.enabled = false;
            fourPathCamera.enabled = true;
        }

        if (i==3) {
            enableCinematics = false;
            firstPathCamera.enabled = false;
            secondPathCamera.enabled = false;
            thirdPathCamera.enabled = false;
            fourPathCamera.enabled = false;
            txt.text = "";
            nextCinematic.SetActive(true);
        }

        i += 1;
        actualDelay = 0;
    }

    private void Update()
    {
        if (enableCinematics == true) {
            string actualDialogue = dialogues[i];
            int dialoguelenght = actualDialogue.Length;

            txt.text = actualDialogue.Substring(0, visibleratio/19);
            if (visibleratio <= dialoguelenght*19) {
                visibleratio += 5;
            } else {
                if (actualDelay <= delayInterDialogues) {
                    actualDelay += 1;
                } else {
                    changeCinematicScene();
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                changeCinematicScene();
            }
        }
    }
}
