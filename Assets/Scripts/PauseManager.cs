using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public static bool gameActive = true;

    public TextMeshProUGUI pauseHeaderText;
    public Button continueButton;
    public Button openSettingsButton;
    public Button exitGameButton;

    //Settings UI
    public TextMeshProUGUI settingsHeader;
    public TextMeshProUGUI bgmText;
    public Slider bgmSlider;
    
    public TextMeshProUGUI sfxText;
    public Slider sfxSlider;
    
    public Button closeSettingsButton;
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
        openSettingsButton.gameObject.SetActive(true);
        exitGameButton.gameObject.SetActive(true);
        gameActive = false;
    }

    public void ContinueGame()
    {
        pauseHeaderText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        openSettingsButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);
        gameActive = true;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Title");
    }

    public void OpenSettings()
    {
        //Disable Pause UI
        pauseHeaderText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        openSettingsButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);

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
        //Enable Pause UI
        pauseHeaderText.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
        openSettingsButton.gameObject.SetActive(true);
        exitGameButton.gameObject.SetActive(true);

        //Disable Settings UI
        settingsHeader.gameObject.SetActive(false);
        sfxText.gameObject.SetActive(false);
        sfxSlider.gameObject.SetActive(false);
        bgmText.gameObject.SetActive(false);
        bgmSlider.gameObject.SetActive(false);
        closeSettingsButton.gameObject.SetActive(false);
    }
}
