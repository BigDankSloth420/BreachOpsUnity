using UnityEngine;
using UnityEngine.AI;

public class BotAI : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentIndex = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GoToNextWaypoint();
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextWaypoint();
        }
    }

    void GoToNextWaypoint()
    {
        if (waypoints.Length == 0) return;
        agent.destination = waypoints[currentIndex].position;
        currentIndex = (currentIndex + 1) % waypoints.Length;
    }
}
