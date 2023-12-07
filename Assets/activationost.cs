using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activationost : MonoBehaviour
{
    // Start is called before the first frame update
    public string tagDuCollider = "ost1";
    
    public GameObject objetAApparaitre;
    public AudioSource MyAudioSource;
    
    void OnTriggerEnter(Collider other)
    {  
        if (other.CompareTag(tagDuCollider))
        {   
            objetAApparaitre.SetActive(true);

            
        }
    }
}