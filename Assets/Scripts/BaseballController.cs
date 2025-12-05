using UnityEngine;

public class BaseballController : MonoBehaviour
{
    public static Vector3 soundLocation;
    public AudioClip ballBounceSound;
    private AudioSource ballAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballAudioSource = GetComponent<AudioSource>();
        soundLocation = new Vector3(0,0,0);
        //AudioSource.PlayClipAtPoint(ballBounceSound, transform.position, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(LucasController.lookDirection == LucasController.Direction.LEFT)
        {
            transform.Translate(Vector3.left * 5f * Time.deltaTime);
        }
        else if(LucasController.lookDirection == LucasController.Direction.RIGHT)
        {
            transform.Translate(Vector3.right * 5f * Time.deltaTime);
        }
        else if(LucasController.lookDirection == LucasController.Direction.UP)
        {
            transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        }
        else if(LucasController.lookDirection == LucasController.Direction.DOWN)
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
