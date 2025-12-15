using UnityEngine;

using UnityEngine.SceneManagement;

public class Level2Exit : MonoBehaviour
{
    public static bool LucasLeftLevel2;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LucasLeftLevel2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene("Level2");
            LucasLeftLevel2 = true;
            Destroy(player);
        }
        else if(other.gameObject.CompareTag("Alice"))
        {
            LucasLeftLevel2 = false;
            SceneManager.LoadScene("Title");
        }
    }
}
