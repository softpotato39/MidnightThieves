using UnityEngine;
using UnityEngine.InputSystem;

public class Digging : MonoBehaviour
{
    public Animator animator;
    public TirednessMeter tirednessMeter;
    public SuspiciousMeter suspiciousMeter;
    public AnimalShift animalShift;
    private bool isDigging;

    public void OnDig(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
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

            if (suspiciousMeter != null)
                suspiciousMeter.AddSuspicion(10f * Time.deltaTime);
        }
    }
}