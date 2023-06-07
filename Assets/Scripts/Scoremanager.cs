using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class Scoremanager : MonoBehaviour
{
    public int score;
    int finalscore;
    [SerializeField] GameObject scoreN, scoreT, highscoreN, highscoreT;
    public TextMeshProUGUI scoreText, highscoreText, finalscoreText;

    public void End()
    {
        finalscore = score;

        scoreN.SetActive(true);
        highscoreN.SetActive(true);
        scoreT.SetActive(true);
        highscoreT.SetActive(true);

        if (finalscore >= PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", finalscore);
        }

        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
        finalscoreText.text = finalscore.ToString();
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

}

