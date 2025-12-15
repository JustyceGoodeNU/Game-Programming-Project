using UnityEngine;

using UnityEngine.SceneManagement;

public class Level1Exit : MonoBehaviour
{
    public static bool LucasLeftLevel1;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LucasLeftLevel1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene("Level2");
            LucasLeftLevel1 = true;
            Destroy(player);
        }
        else if(other.gameObject.CompareTag("Alice"))
        {
            LucasLeftLevel1 = false;
            SceneManager.LoadScene("Level2");
        }
    }
}
