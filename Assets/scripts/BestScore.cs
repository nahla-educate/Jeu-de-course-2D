using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour

{
    public Text BestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        BestScoreText.text = "Best: " + PlayerPrefs.GetInt("BestScore");
        
    }

 private void OnTriggerEnter2D(Collider2D other){

    if(other.gameObject.CompareTag("enemy")){
       Application.LoadLevel(3);
    }
}
}
