using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{   
    Vector2 up = new Vector2(0, 1);
    Vector2 right = new Vector2(1, 0);
    float speed = 0.2f;

    void Update()
    {
        Vector3 position = this.transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.x += up.x * speed;
            position.y += up.y * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.x += -up.x * speed;
            position.y += -up.y * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x += -right.x * speed;
            position.y += -right.y * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += right.x * speed;
            position.y += right.y * speed;
        }
        this.transform.position = position;
    }
}