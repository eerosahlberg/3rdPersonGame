using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1.5f;

    public float velocity;

    public float rotation = 0;

    public float RotTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation -= 40 * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            rotation += 40 * Time.deltaTime;

        }


        bool running = Input.GetKey(KeyCode.LeftShift);
        Speed = running ? 3f : 1.5f;

        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation,ref velocity, RotTime) ;

        
        

        if(transform.position.y <= -3)
        {
            transform.position = new Vector3 (0, 2, 0);
            transform.eulerAngles = new Vector3 (0, 0, 0);
        }

    }
}
