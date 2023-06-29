using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Up();
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            Down();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Left();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Right();
        }
            Boundry();
    }
    void Boundry()
    {
        Vector2 temp = transform.position;
        //translation de player selon l'axe x(horizontale) max =2.1 min -2.1
        if (temp.x<-1.75)
        {
            temp.x = (float)-1.75;
            transform.position = temp;
        }
        if (temp.x > 2.2)
        {
            temp.x = 2.2f;
            transform.position = temp;
        }
        //translation de player selon l'axe y(verticale) max=5 min -5
        if (temp.y < -2f)
        {
            temp.y = -2f;
            transform.position = temp;
        }
        if (temp.y > 4.5f)
        {
            temp.y = 4.5f;
            transform.position = temp;
        }
    }
    //translater vers la gauche
        public void Left()
        {
            Vector2 temp = transform.position;
            temp.x -= 0.08f;
            transform.position = temp;
        }
    //translater vers la droite
        public void Right()
        {
            Vector2 temp = transform.position;
            temp.x += 0.08f;
            transform.position = temp;
        }
    //incrémenter la vitesse
        public void Up()
        {
            rb.velocity = new Vector2(0, speed * Time.deltaTime);
        }
    //décrementer la vitesse 
        public void Down()
        {
            rb.velocity = new Vector2(0, (-1)*speed * Time.deltaTime);
        }
    //stop 
        public void Stop()
        {
        rb.velocity = new Vector2(0, 0);
        }

}
