using UnityEngine;

public class hideUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float visibleTime = 7f;
    private void OnEnable()
    {
        Invoke(nameof(HideUI), visibleTime);
    }

    private void HideUI()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
