using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath : MonoBehaviour
{

    static public Coords GetNormal(Coords vector)
    {
        float lenght = Distance(new Coords(0,0,0), vector);
        vector.x /= lenght;
        vector.y /= lenght;
        vector.z /= lenght;

        return vector;

    }

    static public float Distance(Coords point1, Coords point2)
    {
        float diffSquared = Square(point1.x - point2.x) +
                            Square(point1.y - point2.y) +
                            Square(point1.z - point2.z);
        float squareRoot = Mathf.Sqrt(diffSquared);
        return squareRoot;
    }

    static public float Square(float value)
    {
        return value * value;
    }
}
