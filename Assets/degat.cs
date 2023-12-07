using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class degat : MonoBehaviour

{
    
    public GameObject objetAApparaitre;
   
   public AudioSource death;

     public string tagDuCollider = "miniboss";
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(tagDuCollider)) {
            death.Stop();
 
            objetAApparaitre.SetActive(true);
           
           
            UnityEngine.Debug.Log("let's goooo");
            //using UnityEngine.SceneManagement;
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0); 
            //UnityEngine.SceneManagement.SceneManager.UnloadScene(1);
            ActivateSceneObjects();
            //SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

        }
    }

    void ActivateSceneObjects() {
      Scene s = SceneManager.GetSceneByName("MainMenu");
      GameObject[] gameObjects = s.GetRootGameObjects();

      foreach(GameObject item in gameObjects){
            item.SetActive(true);
        }
  }
}
