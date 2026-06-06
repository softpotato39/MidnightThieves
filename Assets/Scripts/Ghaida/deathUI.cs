using UnityEngine;
using UnityEngine.SceneManagement;

public class deathUI : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("ppppew");
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Raccoon Cage");
        Debug.Log("waaaaaaaaaaak");
    }
}
