using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
   
    public void Retour()
    {
        SceneManager.LoadScene("page_accueil");
    }
    public void Aide()
    {
        SceneManager.LoadScene("instruction");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
