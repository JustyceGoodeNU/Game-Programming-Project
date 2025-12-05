using UnityEngine;

public class BaseballController : MonoBehaviour
{
    public static Vector3 soundLocation;
    public AudioClip ballBounceSound;
    private AudioSource ballAudioSource;
    private LucasController.Direction moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballAudioSource = GetComponent<AudioSource>();
        soundLocation = new Vector3(0,0,0);
        //AudioSource.PlayClipAtPoint(ballBounceSound, transform.position, 1);

        moveDirection = LucasController.lookDirection;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDirection == LucasController.Direction.LEFT)
        {
            transform.Translate(Vector3.left * 5f * Time.deltaTime);
        }
        else if(moveDirection == LucasController.Direction.RIGHT)
        {
            transform.Translate(Vector3.right * 5f * Time.deltaTime);
        }
        else if(moveDirection == LucasController.Direction.UP)
        {
            transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        }
        else if(moveDirection == LucasController.Direction.DOWN)
        {
            transform.Translate(Vector3.back * 5f * Time.deltaTime);
        }
    }

    // public static Vector3 getSoundLocation()
    // {
    //     return soundLocation;
    // }

    private void OnTriggerEnter(Collider other){
        //Debug.Log("Collision detected");
        if(other.gameObject.CompareTag("Wall")){
            //Debug.Log("Collision detected");
            AudioSource.PlayClipAtPoint(ballBounceSound, transform.position, 1);
            Destroy(gameObject);
            soundLocation = transform.position;
            //Debug.Log(transform.position);
            //AudioSource.PlayClipAtPoint(ballBounceSound, Camera.main.transform.position, 1);
            AudioSource.PlayClipAtPoint(ballBounceSound, transform.position, 1);
        }
    }
}
