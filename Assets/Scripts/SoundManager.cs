using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private AudioSource managerAudioSource;
    public Slider bgmVolumeSlider;
    public Slider sfxVolumeSlider;
    public static float sfxVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        managerAudioSource = GetComponent<AudioSource>();

        if(PlayerPrefs.HasKey("bgmVolume")){
            bgmVolumeSlider.value = PlayerPrefs.GetFloat("bgmVolume");
        }
        else{
            bgmVolumeSlider.value = 0.9f;
        }

        if(PlayerPrefs.HasKey("sfxVolume")){
            sfxVolumeSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        }
        else{
            sfxVolumeSlider.value = 0.9f;
        }

        //sfxVolume = 0.4f;
    }

    public void ChangeBgmVolume(){
        //AudioListener.volume = bgmVolumeSlider.value;
        managerAudioSource.volume = bgmVolumeSlider.value;
        PlayerPrefs.SetFloat("bgmVolume", bgmVolumeSlider.value);
    }

    public void ChangeSfxVolume(){
        sfxVolume = sfxVolumeSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxVolumeSlider.value);
        //Debug.Log(sfxVolume);
    }
}
