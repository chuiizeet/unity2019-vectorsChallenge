using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{   
    float speed = 5;
    float stopping = 0.01f;
    public GameObject fuel;
    Vector3 direction;

    private void Start() 
    {
        direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();
    }
    void Update()
    {
        if (HolisticMath.Distance(new Coords(this.transform.position),
                                new Coords(fuel.transform.position)) > stopping)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }
}