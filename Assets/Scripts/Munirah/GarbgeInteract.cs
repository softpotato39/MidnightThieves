using UnityEngine;
using UnityEngine.SceneManagement;

public class GarbageInteract : MonoBehaviour
{
    public GameObject intUI;
    public string sceneToLoad;
    public Animator animator;
    private bool playerInside;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            intUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
          intUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (!playerInside) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
          
                animator.SetBool("Dig", true);

                Invoke(nameof(LoadNextScene), 2f);

            
        }

    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}