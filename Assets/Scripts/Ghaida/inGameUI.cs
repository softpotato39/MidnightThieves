using UnityEngine;
using UnityEngine.SceneManagement;
public class inGameUI : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
