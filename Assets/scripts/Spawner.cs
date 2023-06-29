using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject[] cars;
    public GameObject[] fuels;
    Scene m_Scene;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
      
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "level1")
        {
            StartCoroutine(SpawnItems(4f));
        }
        else
        {
            StartCoroutine(SpawnItems(2f));
        }
    }

    
    IEnumerator SpawnItems(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Vector2 pos = new Vector2(Random.Range(-1,2), transform.position.y);

        Instantiate(cars[Random.Range(0,cars.Length)],pos, Quaternion.identity);
        //Instantiate(fuels[Random.Range(0, fuels.Length)], pos, Quaternion.identity);
        StartCoroutine(SpawnItems(time));

       
    }
}
