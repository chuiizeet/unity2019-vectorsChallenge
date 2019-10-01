using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{   
    Vector2 up = new Vector2(0, 0.1f);
    Vector2 left = new Vector2(-0.1f, 0);

    void Update()
    {
        Vector3 position = this.transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.x += up.x;
            position.y += up.y;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.x += -up.x;
            position.y += -up.y;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x += left.x;
            position.y += left.y;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += -left.x;
            position.y += -left.y;
        }
        this.transform.position = position;
    }
}