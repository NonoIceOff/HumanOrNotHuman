using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sondbilar : MonoBehaviour
{
    public string tagDuCollider = "larbi";
    public GameObject objetADisparaitre;

    public GameObject objetADisparaitre1;
    public GameObject objetAApparaitre;
    public AudioSource MyAudioSource;
    public AudioSource Bilar;




    void OnTriggerEnter(Collider other)
    {  
        if (other.CompareTag(tagDuCollider))
        {   
            objetAApparaitre.SetActive(true);

            // Lancer la cinématique ici
            // Vous pouvez utiliser le système de Timeline d'Unity ou d'autres moyens pour déclencher votre cinématique.
            // Par exemple, si vous utilisez une Timeline, vous pourriez appeler une fonction qui démarre la Timeline.
        }
    }

    void OnTriggerExit(Collider other)
    {
         
        if (other.CompareTag(tagDuCollider))
        {
            //MyAudioSource = GetComponent<AudioSource>();

            // Vous pouvez également lancer une cinématique ou effectuer d'autres actions ici

            // Désactiver l'objet actuel
            objetAApparaitre.SetActive(false);


         
            
        }
        
    }
}

