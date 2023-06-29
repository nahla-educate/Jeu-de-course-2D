using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chrono : MonoBehaviour
{
    [SerializeField] Timer1 timer1;
    Scene m_Scene;
    string sceneName;
    void Start()
    {
        
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "level1")
        {
            timer1.SetDuration(90).Begin();
        }
        else
        {
            timer1.SetDuration(120).Begin();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
