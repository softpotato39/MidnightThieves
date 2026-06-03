using UnityEngine;

public class AnimalFootprint : MonoBehaviour
{
    public AnimalType animalType;

    private void OnTriggerEnter(Collider other)
    {
        AnimalShift player =
            other.GetComponent<AnimalShift>();

        if (player != null)
        {
            player.UnlockAnimal(animalType);

            Destroy(gameObject);
        }
    }
}
