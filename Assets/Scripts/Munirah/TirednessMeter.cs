using UnityEngine;

public class TirednessMeter : MonoBehaviour
{
    public float currentTiredness = 0f;
    public float maxTiredness = 100f;

    public void AddTiredness(float amount)
    {
        currentTiredness += amount;
        currentTiredness = Mathf.Clamp(
            currentTiredness,
            0,
            maxTiredness
        );
    }

    public bool IsExhausted()
    {
        return currentTiredness >= maxTiredness;
    }
}