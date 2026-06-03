using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public Transform player;

    public SuspiciousMeter suspiciousMeter;

    private NavMeshAgent agent;

    private bool chasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
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
    void Update()
    {
        if (!chasing &&
            suspiciousMeter.IsMaxSuspicion())
        {
            chasing = true;
        }

        if (chasing)
        {
            agent.SetDestination(
                player.position
            );
        }
    }
}