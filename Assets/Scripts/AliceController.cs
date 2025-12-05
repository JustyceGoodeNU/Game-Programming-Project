using UnityEngine;

public class AliceController : MonoBehaviour
{
    public GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    public static bool followLucas = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //player = GameObject.Find("Lucas");
    }

    // Update is called once per frame
    void Update()
    {
        if(followLucas)
        {
            agent.SetDestination(player.transform.position);
            BaseballController.soundLocation = Vector3.zero;
        }
        else if(BaseballController.soundLocation != Vector3.zero)
        {
            agent.SetDestination(BaseballController.soundLocation);
        }
    }
}
