using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public TextMeshProUGUI pauseHeaderText;
    public Button continueButton;
    public Button exitGameButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseHeaderText.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
        exitGameButton.gameObject.SetActive(true);
    }

    public void ContinueGame()
    {
        pauseHeaderText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Title");
    }
}
