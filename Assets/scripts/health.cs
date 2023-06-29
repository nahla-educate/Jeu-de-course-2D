using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Text Myhealth;
    private int HealthNum;

    // Start is called before the first frame update
    void Start()
    {

        HealthNum = 5;
        Myhealth.text = "" + HealthNum;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fuel")
        {
            HealthNum += 1;
            Destroy(gameObject);
            Myhealth.text = "" + HealthNum;
        }

    }
}
