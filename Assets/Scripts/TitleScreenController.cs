using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TitleScreenController : MonoBehaviour
{
    public Button startGameButton;

    //public Button startGameButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    public void StartGame(){
        SceneManager.LoadScene("Level1");
    }
}
