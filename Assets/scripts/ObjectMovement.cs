using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;
    public float maxSpeed;private bool test;
    //private GameObject cars;
    // Start is called before the first frame update
    void Start()
    {
        //départ
        speed+= 0.003f*Time.time;
        if(speed >= maxSpeed)
        {
            speed = maxSpeed;
        }
       // cars.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
     

}

    void Move()
    {
        //la vitesse tout au long le jeu
        Vector2 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        transform.position = temp;

    }
}
