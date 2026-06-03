using UnityEngine;

public class AnimalNPC : MonoBehaviour
{
    public AnimalType animalType;

    public Transform player;

    private AnimalShift playerAnimal;

    private void Start()
    {
        playerAnimal =
            player.GetComponent<AnimalShift>();
    }

    private void Update()
    {
        if (playerAnimal.currentAnimal != animalType)
        {
            transform.LookAt(player);

            transform.position =
                Vector3.MoveTowards(
                    transform.position,
                    player.position,
                    3f * Time.deltaTime);
        }
    }
}
