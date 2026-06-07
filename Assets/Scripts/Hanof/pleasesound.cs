using UnityEngine;
using System.Collections;

public class pleasesound : MonoBehaviour
{
    public AudioSource yippy;
    public float delayTime = 5.0f; // Seconds to delay

    void Start()
    {
        StartCoroutine(PlaySoundWithDelay());
    }

    IEnumerator PlaySoundWithDelay()
    {
        yield return new WaitForSeconds(delayTime);
        yippy.Play();
    }
}
