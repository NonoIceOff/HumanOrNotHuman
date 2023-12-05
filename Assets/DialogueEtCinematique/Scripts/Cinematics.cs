using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematics : MonoBehaviour
{
    public Camera firstPathCamera;
    public Camera secondPathCamera;
    public Camera thirdPathCamera;
    public Camera fourPathCamera;

    int i;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
