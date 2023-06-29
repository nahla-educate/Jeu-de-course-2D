using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
public class GameManager : MonoBehaviour
{
    [SerializeField]  public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject WinPanel;
    public Text Myhealth;
    private int HealthNum;
    [Header("Timer UI references :")]
    [SerializeField] public Image uiFillImage;
    [SerializeField] public Text uiText;
    private int remainingDuration;
    Scene m_Scene;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        WinPanel.SetActive(false);
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "level1")
        {
            HealthNum = 5;
            Myhealth.text = "" + HealthNum;
        }else
        {
            HealthNum = 3;
            Myhealth.text = "" + HealthNum;
        }


    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continuer()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
   
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
     if (collision.gameObject.tag == "obstacle")
        {
            GameObject obj = collision.gameObject;
            Destroy(obj);
     
            this.HealthNum -= 1;
            
            if(this.HealthNum == 0)
            {
                Application.LoadLevel(3);
            }
            Myhealth.text = "" + this.HealthNum;
            

            /*if(HealthNum == -1)
                 Myhealth.text = "" + 4;
            else if(HealthNum == -2)
                Myhealth.text = "" + 3;
            else if(HealthNum == -3)
                Myhealth.text = "" + 2;
            else if(HealthNum == -4)
                Myhealth.text = "" + 1;*/
            // else
            //Application.LoadLevel(3);
            // 

        }
        else
        {
            //collision player fuel
            if (collision.gameObject.tag == "fuel")
            {


                GameObject obj = collision.gameObject;
                Destroy(obj);

                this.HealthNum += 1;

                Myhealth.text = "" + this.HealthNum;

            }
        }
     
    }

}
