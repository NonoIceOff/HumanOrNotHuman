using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiontitan : MonoBehaviour
{
    public string tagDuCollider = "collision";
    public GameObject objetADisparaitre;
    public GameObject objetAApparaitre;
    public GameObject objetAApparaitre1;
    public GameObject objetAApparaitre2;
    public GameObject objetAApparaitre3;
    public GameObject objetAApparaitre4;





    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagDuCollider))
        {
            // Lancer la cinématique ici
            // Vous pouvez utiliser le système de Timeline d'Unity ou d'autres moyens pour déclencher votre cinématique.
            // Par exemple, si vous utilisez une Timeline, vous pourriez appeler une fonction qui démarre la Timeline.
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagDuCollider))
        {
            // Vous pouvez également lancer une cinématique ou effectuer d'autres actions ici

            // Désactiver l'objet actuel
            objetADisparaitre.SetActive(false);

            // Activer l'objet de remplacement
            objetAApparaitre.SetActive(true);
            objetAApparaitre1.SetActive(true);
            objetAApparaitre2.SetActive(true);
            objetAApparaitre3.SetActive(true);
            objetAApparaitre4.SetActive(true);
        }
    }
}

