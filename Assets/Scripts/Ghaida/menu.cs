using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("");
        Debug.Log("ppppew");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
