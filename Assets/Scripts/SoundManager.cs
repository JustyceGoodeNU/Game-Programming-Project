using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider sfxVolumeSlider;
    public static float sfxVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(PlayerPrefs.HasKey("sfxVolume")){
            sfxVolumeSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        }
        else{
            sfxVolumeSlider.value = 0.4f;
        }

        //sfxVolume = 0.4f;
    }

    public void ChangeSfxVolume(){
        sfxVolume = sfxVolumeSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxVolumeSlider.value);
        //Debug.Log(sfxVolume);
    }
}
