using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cinematics2 : MonoBehaviour
{
    public Camera firstPathCamera;

    public TextMeshProUGUI txt;

    public bool enableCinematics;

    public int delayInterDialogues;

    public AudioSource son;
    
    public AudioSource StopOst;

    int actualDelay;

    int i;
    int visibleratio;

    public string[] dialogues = {"dialogue 1"};

    string actualDialogue;
    int dialoguelenght;

    private void Start()
    {   
        StopOst.Stop();
        i = 0;
        actualDelay = 0;
        if (enableCinematics == true) {
            firstPathCamera.enabled = true;
            son.Play();
        }
        
        
    }

    private void changeCinematicScene() {
        actualDialogue = dialogues[i];
        dialoguelenght = actualDialogue.Length;
        visibleratio = 0;


        if (i==1) {
            enableCinematics = false;
            firstPathCamera.enabled = false;
            txt.text = "";
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
