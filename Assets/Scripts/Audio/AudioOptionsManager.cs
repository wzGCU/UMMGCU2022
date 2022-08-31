using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

// Enabling the use of two interactable audio channels so the player can alter the SFX and Music volume separately

public class AudioOptionsManager : MonoBehaviour
{
    public static float musicVolume { get; private set; }
    public static float soundEffectsVolume { get; private set; }

    [SerializeField]
    private TextMeshProUGUI musicSliderText;

    [SerializeField]
    private TextMeshProUGUI SFXSliderText;

    public void MusicSliderValueChange(float sliderValue)
    {
        musicVolume = sliderValue;
        musicSliderText.text = ((int)(sliderValue * 100)).ToString() + "%";
        AudioManager.instance.UpdateMixerVolume();
    }

    public void SFXSliderValueChange(float sliderValue)
    {
        soundEffectsVolume = sliderValue;
        SFXSliderText.text = ((int)(sliderValue * 100)).ToString() + "%";
        AudioManager.instance.UpdateMixerVolume();
    }
}