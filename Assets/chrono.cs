using UnityEngine;
using UnityEngine.UI; // N'oubliez pas d'ajouter cette ligne pour utiliser l'interface utilisateur Unity.

public class Chrono : MonoBehaviour
{
    public Text texteChrono; // Référence à l'élément Text de l'interface utilisateur
    public float chronometre;

    void Start()
    {
        chronometre = 0;
        texteChrono.text = "0:00"; // Initialisation du texte
    }

    void Update()
    {
        chronometre += Time.deltaTime;

        // Convertit le temps en minutes:secondes
        string tempsFormatte = string.Format("{0:0}:{1:00}", Mathf.Floor(chronometre / 60), chronometre % 60);

        // Met à jour le texte de l'interface utilisateur
        texteChrono.text = tempsFormatte;
    }
}
