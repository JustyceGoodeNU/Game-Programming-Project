using UnityEngine;

public class AliceController : MonoBehaviour
{
    //private Vector3 moveLocation;
    public GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    public static bool followLucas = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //moveLocation = null;
        //player = GameObject.Find("Lucas");
    }

    // Update is called once per frame
    void Update()
    {
        // if(moveLocation != null)
        // {
        //     transform.position = moveLocation;
        //     moveLocation = null;
        // }

        if(followLucas)
        {
            agent.SetDestination(player.transform.position);
        }
        else if(BaseballController.soundLocation != Vector3.zero)
        {
            agent.SetDestination(BaseballController.soundLocation);
        }
    }
}
