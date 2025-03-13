using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{   
    private GameObject player;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
    }
}
