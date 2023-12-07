using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiontitan : MonoBehaviour
{
    public string tagDuCollider = "collision";
    public GameObject objetADisparaitre;
    public GameObject objetADisparaitre1;

    public GameObject objetADisparaitre2;
    
    public GameObject objetADisparaitre3;
    
    public GameObject objetADisparaitre4;
    
    public GameObject objetADisparaitre5;
    public GameObject objetADisparaitre6;

    public GameObject objetADisparaitre7;
    
    public GameObject objetADisparaitre8;
    
    public GameObject objetADisparaitre9;
    
    public GameObject objetADisparaitre10;
    public GameObject objetADisparaitre11;
    public GameObject objetADisparaitre12;

    public GameObject objetADisparaitre13;
    
    public GameObject objetADisparaitre14;
    
    public GameObject objetADisparaitre15;
    
    public GameObject objetADisparaitre16;
    public GameObject objetADisparaitre17;

    public GameObject objetADisparaitre18;
    
    public GameObject objetADisparaitre19;
    
    public GameObject objetADisparaitre20;
    
    public GameObject objetADisparaitre21;
    public GameObject objetADisparaitre22;
    public GameObject objetADisparaitre23;
    
    public GameObject objetADisparaitre24;
    
    public GameObject objetADisparaitre25;
    public GameObject objetADisparaitre26;

    public GameObject objetADisparaitre27;
    
    public GameObject objetADisparaitre28;
    
    public GameObject objetADisparaitre29;
    
    public GameObject objetADisparaitre30;
    public GameObject objetADisparaitre31;
    public GameObject objetADisparaitre32;

    public GameObject objetADisparaitre33;
    
    public GameObject objetADisparaitre34;
    
    public GameObject objetADisparaitre35;
    
    public GameObject objetAApparaitre;
    public GameObject objetAApparaitre1;
    public GameObject objetAApparaitre2;
    public GameObject objetAApparaitre3;
    public GameObject objetAApparaitre4;
    public AudioSource MyAudioSource;
    public AudioSource Bilar;

    public GameObject nextCinematic; 




    void OnTriggerEnter(Collider other)
    {  
        if (other.CompareTag(tagDuCollider))
        {   
            MyAudioSource.Stop();
            
            
            
            // Lancer la cinématique ici
            // Vous pouvez utiliser le système de Timeline d'Unity ou d'autres moyens pour déclencher votre cinématique.
            // Par exemple, si vous utilisez une Timeline, vous pourriez appeler une fonction qui démarre la Timeline.
            objetADisparaitre1.SetActive(false);
            objetADisparaitre2.SetActive(false);
            objetADisparaitre3.SetActive(false);
            objetADisparaitre4.SetActive(false);
            objetADisparaitre5.SetActive(false);
            objetADisparaitre6.SetActive(false);
            objetADisparaitre7.SetActive(false);
            objetADisparaitre8.SetActive(false);
            objetADisparaitre9.SetActive(false);
            objetADisparaitre10.SetActive(false);
            objetADisparaitre11.SetActive(false);
            objetADisparaitre12.SetActive(false);
            objetADisparaitre13.SetActive(false);
            objetADisparaitre14.SetActive(false);
            objetADisparaitre15.SetActive(false);
            objetADisparaitre16.SetActive(false);
            objetADisparaitre17.SetActive(false);
            objetADisparaitre18.SetActive(false);
            objetADisparaitre19.SetActive(false);
            objetADisparaitre20.SetActive(false);
            objetADisparaitre21.SetActive(false);
            objetADisparaitre22.SetActive(false);
            objetADisparaitre23.SetActive(false);
            objetADisparaitre24.SetActive(false);
            objetADisparaitre25.SetActive(false);
            objetADisparaitre26.SetActive(false);
            objetADisparaitre27.SetActive(false);
            objetADisparaitre28.SetActive(false);
            objetADisparaitre29.SetActive(false);
            nextCinematic.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
         
        if (other.CompareTag(tagDuCollider))
        {
            //MyAudioSource = GetComponent<AudioSource>();

            // Vous pouvez également lancer une cinématique ou effectuer d'autres actions ici

            // Désactiver l'objet actuel
            objetADisparaitre.SetActive(false);
            
            
            // Activer l'objet de remplacement
            objetAApparaitre.SetActive(true);
            objetAApparaitre1.SetActive(true);
            objetAApparaitre2.SetActive(true);
            objetAApparaitre3.SetActive(true);
            objetAApparaitre4.SetActive(true);
            objetADisparaitre5.SetActive(true);
            objetADisparaitre6.SetActive(true);
            objetADisparaitre7.SetActive(true);
            objetADisparaitre8.SetActive(true);
            objetADisparaitre9.SetActive(true);
            objetADisparaitre10.SetActive(true);
            objetADisparaitre11.SetActive(true);
            objetADisparaitre12.SetActive(true);
            objetADisparaitre13.SetActive(true);
            objetADisparaitre14.SetActive(true);
            objetADisparaitre15.SetActive(true);
            objetADisparaitre16.SetActive(true);
            objetADisparaitre17.SetActive(true);
            objetADisparaitre18.SetActive(true);
            objetADisparaitre19.SetActive(true);
            objetADisparaitre20.SetActive(true);
            objetADisparaitre21.SetActive(true);
            objetADisparaitre22.SetActive(true);
            objetADisparaitre23.SetActive(true);
            objetADisparaitre24.SetActive(true);
            objetADisparaitre25.SetActive(true);
            objetADisparaitre26.SetActive(true);
            objetADisparaitre27.SetActive(true);
            objetADisparaitre28.SetActive(true);
            objetADisparaitre29.SetActive(true);

        }
        
    }
}

