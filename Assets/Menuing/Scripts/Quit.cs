using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void button_exit()
    {
        Application.Quit();
    }

    public void button_play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}