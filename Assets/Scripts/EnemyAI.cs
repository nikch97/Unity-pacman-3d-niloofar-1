using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
// FSM States for the enemy
public enum EnemyState { CHASE, MOVING, DEFAULT };
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAI : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    public float chaseDistance = 20.0f;
    protected EnemyState state = EnemyState.DEFAULT;
    protected Vector3 destination = new Vector3(0, 0, 0);

    //attacking ghost
    [SerializeField]
    public GameObject playerObject;
    [SerializeField]
    public float speed = 1.5f;
    private Vector3 offset = new Vector3(0, .6f, 0);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent = this.GetComponent<NavMeshAgent>();
       
    }
    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-50.0f, 50.0f), 0, Random.Range(-50.0f, 50.0f));
    }
    // Update is called once per frame
    void Update()
    {
       
        switch (state)
        {
            case EnemyState.DEFAULT
        :
                destination = transform.position + RandomPosition();
                if (Vector3.Distance(transform.position, player.transform.position) < chaseDistance
                )
                {
                    state = EnemyState.CHASE;
                    transform.position = Vector3.MoveTowards(transform.position, playerObject.transform.position + offset, speed * Time.deltaTime);
                }
                else
                {
                    state = EnemyState.MOVING;
                    agent.SetDestination(destination);
                }
                break;

            case EnemyState.MOVING
        :
                //Debug.Log("Dest = " + destination);
                if (Vector3.Distance(transform.position, destination) < 0.05f)
                {
                    state = EnemyState.DEFAULT
                    ;
                }
                if (Vector3.Distance(transform.position, player.transform.position) < chaseDistance
                )
                {
                    state = EnemyState.CHASE
                    ;
                }
                break;
            case EnemyState.CHASE
        :
                if (Vector3.Distance(transform.position, player.transform.position) > chaseDistance
                )
                {
                    state = EnemyState.DEFAULT
                    ;
                }
                agent.SetDestination
                (player.transform.position);
                break;
            default:
                break;
        }
    }

 private void OnTriggerEnter(Collider col) {
        PlayerInventory playerInventory = col.GetComponent<PlayerInventory>();

        if (col.gameObject.tag == playerObject.tag) {
            playerInventory.Energy = playerInventory.Energy - 2;
            Debug.Log("Hit player");
        }

    }


}