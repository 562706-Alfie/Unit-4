using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public Player pl;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = "Score:" + pl.score.ToString();
    }
}
