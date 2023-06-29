using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    float score;
    Scene m_Scene;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += 3 * Time.deltaTime;
        PlayerPrefs.SetInt("Score", (int)score);
        ScoreText.text = "Score: " + (int)score;
        if(PlayerPrefs.GetInt("BestScore")<score)
        {
            PlayerPrefs.SetInt("BestScore", (int)score);
        }

        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "level1")
        {
            if (PlayerPrefs.GetInt("Score") == 200)
            {
                Application.LoadLevel(5);
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("Score") == 400)
            {
                Application.LoadLevel(5);
            }
        }

       
    }
}
