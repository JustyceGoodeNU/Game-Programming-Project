using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TitleScreenController : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Button startGameButton;
    public Button exitGameButton;
    public Button openSettingsButton;

    //Settings UI
    public TextMeshProUGUI settingsHeader;
    public TextMeshProUGUI bgmText;
    public Slider bgmSlider;
    
    public TextMeshProUGUI sfxText;
    public Slider sfxSlider;
    
    public Button closeSettingsButton;

    //public Button startGameButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    public void StartGame(){
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void OpenSettings()
    {
        //Disable Title UI
        titleText.gameObject.SetActive(false);
        startGameButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);
        openSettingsButton.gameObject.SetActive(false);

        //Enable Settings UI
        settingsHeader.gameObject.SetActive(true);
        sfxText.gameObject.SetActive(true);
        sfxSlider.gameObject.SetActive(true);
        bgmText.gameObject.SetActive(true);
        bgmSlider.gameObject.SetActive(true);
        closeSettingsButton.gameObject.SetActive(true);
    }

    public void CloseSettings()
    {
        //Enable Title UI
        titleText.gameObject.SetActive(true);
        startGameButton.gameObject.SetActive(true);
        exitGameButton.gameObject.SetActive(true);
        openSettingsButton.gameObject.SetActive(true);

        //Disable Settings UI
        settingsHeader.gameObject.SetActive(false);
        sfxText.gameObject.SetActive(false);
        sfxSlider.gameObject.SetActive(false);
        bgmText.gameObject.SetActive(false);
        bgmSlider.gameObject.SetActive(false);
        closeSettingsButton.gameObject.SetActive(false);
    }
}
