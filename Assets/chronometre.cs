using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronometre : MonoBehaviour
{
    private float tempsDebut;
    private bool chronoEnCours = false;

    void Start()
    {
        // Initialise le temps de début au moment où le script est activé
        tempsDebut = Time.time;
        // Démarre le chronomètre
        chronoEnCours = true;
    }

    void Update()
    {
        if (chronoEnCours)
        {
            // Calcule le temps écoulé depuis le début
            float tempsEcoule = Time.time - tempsDebut;

            // Convertit le temps écoulé en minutes:secondes
            string tempsFormatte = string.Format("{0:0}:{1:00}", Mathf.Floor(tempsEcoule / 60), tempsEcoule % 60);

            // Affiche le temps à l'écran (assurez-vous d'ajuster la position et le style selon vos besoins)
            GUI.Label(new Rect(10, 10, 200, 20), "Temps écoulé : " + tempsFormatte);
        }
    }

    // Méthode pour arrêter le chronomètre
    void ArreterChronometre()
    {
        chronoEnCours = false;
    }

    // Vous pouvez appeler cette méthode lorsque vous voulez arrêter le chronomètre, par exemple, à la fin d'un niveau.
}


