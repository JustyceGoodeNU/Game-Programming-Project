using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TitleScreenController : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Button startGameButton;
    public Button openSettingsButton;
    public Button openControlsButton;
    public Button exitGameButton;
    
    //Settings UI
    public TextMeshProUGUI settingsHeader;
    public TextMeshProUGUI bgmText;
    public Slider bgmSlider;
    
    public TextMeshProUGUI sfxText;
    public Slider sfxSlider;
    
    public Button closeSettingsButton;

    //Controls UI
    public TextMeshProUGUI controlsHeader;
    public TextMeshProUGUI controlsText;
    public Button closeControlsButton;

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
        openControlsButton.gameObject.SetActive(false);

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
        openControlsButton.gameObject.SetActive(true);

        //Disable Settings UI
        settingsHeader.gameObject.SetActive(false);
        sfxText.gameObject.SetActive(false);
        sfxSlider.gameObject.SetActive(false);
        bgmText.gameObject.SetActive(false);
        bgmSlider.gameObject.SetActive(false);
        closeSettingsButton.gameObject.SetActive(false);
    }

    public void OpenControls()
    {
        //Disable Title UI
        titleText.gameObject.SetActive(false);
        startGameButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);
        openSettingsButton.gameObject.SetActive(false);
        openControlsButton.gameObject.SetActive(false);

        //Enable Controls UI
        controlsHeader.gameObject.SetActive(true);
        controlsText.gameObject.SetActive(true);
        closeControlsButton.gameObject.SetActive(true);
    }

    public void CloseControls()
    {
        //Enable Title UI
        titleText.gameObject.SetActive(true);
        startGameButton.gameObject.SetActive(true);
        exitGameButton.gameObject.SetActive(true);
        openSettingsButton.gameObject.SetActive(true);
        openControlsButton.gameObject.SetActive(true);

        //Disable Controls UI
        controlsHeader.gameObject.SetActive(false);
        controlsText.gameObject.SetActive(false);
        closeControlsButton.gameObject.SetActive(false);
    }
}
