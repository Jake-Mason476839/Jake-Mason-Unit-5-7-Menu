using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetSFXVolume (float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
