using UnityEngine;

public class AnimalFootprint : MonoBehaviour
{
    public AnimalType animalType;
    public GameObject ShiftUI;
    private void OnTriggerEnter(Collider other)
    {
        AnimalShift player =
            other.GetComponent<AnimalShift>();
        if (other.CompareTag("Player") )
            ShiftUI.SetActive(true);
        {
            ShiftUI.SetActive(true);
        }

        if (player != null)
        {
            player.UnlockAnimal(animalType);

            Destroy(gameObject);
        }
    }
}
