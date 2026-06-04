using UnityEngine;
using UnityEngine.SceneManagement;

public class GarbageInteract : MonoBehaviour
{
    public float requiredTiredness = 50f;
    public string sceneToLoad;
    public Animator animator;
    private bool playerInside;
    private TirednessMeter tirednessMeter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            tirednessMeter = other.GetComponent<TirednessMeter>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            tirednessMeter = null;
        }
    }

    private void Update()
    {
        if (!playerInside) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (tirednessMeter != null &&
                tirednessMeter.currentTiredness >= requiredTiredness)
            {
                animator.SetBool("Dig", true);

                Invoke(nameof(LoadNextScene), 2f);

            }
        }

    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}