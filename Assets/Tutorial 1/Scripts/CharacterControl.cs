using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharController : MonoBehaviour
{
    public float speed = 10.0f;
    public float maxspeed = 100.0f;
    public float acc = 5.0f;
    public float dec = 5.0f;
    public float rotation = 0.0f;

    // Update is called once per frame.
    void Update()
    {
        if (Input.GetKey("space"))
        {
            if(speed < maxspeed)
            {
                speed += acc;
            }
        }
        else
        {
            if(speed > 0)
            {
                speed -= dec;
            }
        }
        transform.position += transform.forward * Time.deltaTime * speed;

        if ((Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Rotate(0, 2.0f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,-2.0f, 0);
        }

        if ((Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-0.5f, 0, 0);
        }
    }
}