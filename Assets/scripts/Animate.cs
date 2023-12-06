using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator PlayerAnimator;

    void Awake() 
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAnimator.SetFloat("run", Input.GetAxis("Vertical"));
    }
}
