using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoremanager : MonoBehaviour
{
    public int score;
    int finalscore;
    [SerializeField] GameObject scoreN, scoreT, highscoreN, highscoreT, retryB, shootg;
    public TextMeshProUGUI scoreText, highscoreText, finalscoreText;
    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Time.timeScale = 1;
    }
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

        retryB.SetActive(true);
        shootg.SetActive(false);
        Time.timeScale = 0;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

}

