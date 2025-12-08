using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    //public variable to reference the button text - set this up in the Unity editor
    public TMP_Text buttonText;

    public void ButtonMethod()
    {
        FindFirstObjectByType<AudioManager>().Play("MenuSelect");
        buttonText.text = "Resetting!";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        LevelManager.instance.playerHealth = 100;
    }

    public void Play1Method()
    {
        FindFirstObjectByType<AudioManager>().Play("MenuSelect");
        SceneManager.LoadScene("Level 1");
        LevelManager.instance.playerHealth = 100;
    }

    public void Play2Method()
    {
        FindFirstObjectByType<AudioManager>().Play("MenuSelect");
        SceneManager.LoadScene("Level 2");
        LevelManager.instance.playerHealth = 100;
    }

    public void Play3Method()
    {
        FindFirstObjectByType<AudioManager>().Play("MenuSelect");
        SceneManager.LoadScene("Level 3");
        LevelManager.instance.playerHealth = 100;
    }

    public void ChangeMusicVolume(float volume)
    {
        AudioManager.instance.musicVolume = volume;
    }

    public void ChangeSFXVolume(float volume)
    {
        AudioManager.instance.sfxVolume = volume;
    }

    public void PlayMenuHover()
    {
        AudioManager.instance.Play("MenuHover");
    }

    public void PlayMenuSelect()
    {
        AudioManager.instance.Play("MenuSelect");
    }
}