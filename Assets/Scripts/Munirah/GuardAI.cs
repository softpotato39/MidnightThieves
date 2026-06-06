using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

   

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            other.GetComponent<PlayerHealth>()?.TakeDamage(20);


        }
    }
    void Update()
    {
       agent.SetDestination(player.position);

        
    }
}