using UnityEngine;

using UnityEngine.SceneManagement;

public class AliceController : MonoBehaviour
{
    public GameObject player;
    private Animator animator;
    public UnityEngine.AI.NavMeshAgent agent;
    public static bool followLucas = false;

    Vector2 lookDirection = new Vector2(0,0); //Direction that the enemy looks at the player
    float lookAngle = 0;
    //float lookRadian = 0;
    float dist = 0; //Distance between Alice and destination

    public GameObject levelExit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        agent.ResetPath();
    }

    // Update is called once per frame
    void Update()
    {   
        if (PauseManager.gameActive)
        {
            //Check if Alice is moving
            if(agent.hasPath && dist > 1.5){
                animator.SetBool("isMoving", true);
            }
            else{
                animator.SetBool("isMoving", false);
            }

            if(Level1Exit.LucasLeftLevel1 || Level2Exit.LucasLeftLevel2)
            {
                agent.SetDestination(levelExit.transform.position);
            }
            else if(followLucas)
            {
                agent.SetDestination(player.transform.position);
                
                BaseballController.soundLocation = Vector3.zero;
            }
            else if(BaseballController.soundLocation != Vector3.zero)
            {
                agent.SetDestination(BaseballController.soundLocation);
            }

            if(agent.hasPath)
            {
                lookDirection = new Vector2(agent.destination.x, agent.destination.z) - new Vector2(transform.position.x, transform.position.z);
                lookDirection = lookDirection.normalized;
                lookAngle = Vector2.SignedAngle(Vector2.right, lookDirection);
                transform.eulerAngles = new Vector3(0, -lookAngle + 90, 0);
                dist = Vector3.Distance(transform.position, agent.destination);
            }
        }
        else
        {
            agent.ResetPath();
        }
    }
}
