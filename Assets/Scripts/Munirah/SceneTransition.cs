using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;

    public int checkpointID;

    private bool playerInside = false;

    private void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            CheckpointManager.Instance.SaveCheckpoint(
                checkpointID
            );

            SceneManager.LoadScene(
                sceneToLoad
            );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}