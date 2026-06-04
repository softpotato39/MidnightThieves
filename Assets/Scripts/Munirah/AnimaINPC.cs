using UnityEngine;

public class AnimalNPC : MonoBehaviour
{
    public AnimalType animalType;

    public Transform player;

    private AnimalShift playerAnimal;
    public bool isAggressive = true;

    private void Start()
    {
        playerAnimal =
            player.GetComponent<AnimalShift>();
    }

    private void Update()
    {
        if (!isAggressive)
            return;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health =
                other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.TakeDamage(5);
            }
        }
    }
}
