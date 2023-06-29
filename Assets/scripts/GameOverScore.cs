using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text BestScoreText;
    public Text ScoreText;

    void Start()
    {
        ScoreText.text = "" + PlayerPrefs.GetInt("Score");
        BestScoreText.text = "" + PlayerPrefs.GetInt("BestScore");
    }
}
