using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{   
    float speed = 5;
    float stopping = 0.1f;
    public GameObject fuel;
    Vector3 direction;

    private void Start() 
    {
        // direction = fuel.transform.position - this.transform.position;
        // Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        // direction = dirNormal.ToVector();
        
        this.transform.up = HolisticMath.LookAt2D(new Coords(this.transform.forward),
                                                    new Coords(this.transform.position),
                                                    new Coords(fuel.transform.position)).ToVector();
        // direction = fuel.transform.position - this.transform.position;
        // Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        // direction = dirNormal.ToVector();
        // float a = HolisticMath.Angle(new Coords(this.transform.up), new Coords(direction));

        // bool clockwise = false;

        // if(HolisticMath.Cross(new Coords(this.transform.up), dirNormal).z < 0)
        // {
        //     clockwise = true;
        // }

        // Coords newDir = HolisticMath.Rotate(new Coords(this.transform.up), a, clockwise);
        // this.transform.up = new Vector3(newDir.x, newDir.y, newDir.z);
    }
    void Update()
    {
        if(HolisticMath.Distance(new Coords(this.transform.position),
                                new Coords(fuel.transform.position)) > stopping)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }
}