using UnityEngine;
using UnityEngine.InputSystem;

public class Digging : MonoBehaviour
{
    public Animator animator;
    public TirednessMeter tirednessMeter;
    
    public AnimalShift animalShift;
    private bool isDigging;

    public void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log("working");
        isDigging = context.ReadValueAsButton();

        animator.SetBool("Dig", isDigging);
    }

    private void Update()
    {
        if (animalShift.currentAnimal != AnimalType.Raccoon)
            return;

        if (isDigging)
        {
            tirednessMeter.AddTiredness(5f * Time.deltaTime);

        
        }
    }
}