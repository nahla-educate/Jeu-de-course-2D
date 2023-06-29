using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject[] obstacle;
    public GameObject fuel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItems(2f));
        StartCoroutine(Spawnfuel(8f));
    }
    
        IEnumerator SpawnItems(float time)
        {
            yield return new WaitForSecondsRealtime(time);
            Vector2 pos = new Vector2(Random.Range(-1, 2), Random.Range(3, 4));

            Instantiate(obstacle[Random.Range(0, obstacle.Length)], pos, Quaternion.identity);
            StartCoroutine(SpawnItems(Random.Range(4f, 6f)));


    }
    IEnumerator Spawnfuel(float time)
        {
            yield return new WaitForSecondsRealtime(time);
            Vector2 pos = new Vector2(Random.Range(-1, 2), Random.Range(3, 4));

            Instantiate(fuel, pos, Quaternion.identity);
            StartCoroutine(SpawnItems(Random.Range(7f, 10f)));


    }
    

}
