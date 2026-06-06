using UnityEngine;

public class SuspiciousMeter : MonoBehaviour
{
    public float suspicion = 0f;
    public float maxSuspicion = 100f;

    public bool IsMaxSuspicion()
    {
        return suspicion >= maxSuspicion;
    }

    public void AddSuspicion(float amount)
    {
        suspicion += amount;

        suspicion = Mathf.Clamp(
            suspicion,
            0,
            maxSuspicion
        );
    }
}