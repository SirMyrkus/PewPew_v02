using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public int score;
    int finalscore;
    
    public void End()
    {
        if (finalscore >= PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", finalscore);
        }
    }

}
