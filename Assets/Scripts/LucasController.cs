using UnityEngine;

public class LucasController : MonoBehaviour
{
    private float speed = 1f;
    private Rigidbody playerRb;
    public GameObject baseBallprefab;

    private float fireRate = 0.45f;
    private float canFire = 0f;

    public enum Direction
    {
        LEFT, RIGHT, UP, DOWN
    }

    public static Direction lookDirection = Direction.UP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;
        playerRb.MovePosition(playerRb.position + movement * Time.fixedDeltaTime * Time.timeScale);

        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left");
            lookDirection = Direction.LEFT;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Right");
            lookDirection = Direction.RIGHT;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Up");
            lookDirection = Direction.UP;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Down");
            lookDirection = Direction.DOWN;
        }

        if(Input.GetMouseButton(0) && Time.time > canFire)
        {
            canFire = Time.time + fireRate;
            Instantiate(baseBallprefab, transform.position + new Vector3(0,0,0), transform.rotation);
        }
    }
}
