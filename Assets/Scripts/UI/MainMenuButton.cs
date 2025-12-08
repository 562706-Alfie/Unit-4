using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    //public variable to reference the button text - set this up in the Unity editor
    public TMP_Text playText;

    public void ButtonMethod()
    {
        FindFirstObjectByType<AudioManager>().Play("MenuSelect");
        playText.text = "Returning";
        SceneManager.LoadScene("Main Menu");
    }
}