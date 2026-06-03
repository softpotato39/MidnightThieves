using UnityEngine;
using UnityEngine.InputSystem;

public class Digging : MonoBehaviour
{
    public SuspiciousMeter suspiciousMeter;

    private bool isDigging;

    public void OnDig(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        isDigging = context.ReadValueAsButton();
    }

    private void Update()
    {
        if (isDigging)
        {
            suspiciousMeter.AddSuspicion(10f * Time.deltaTime);
        }
    }
}