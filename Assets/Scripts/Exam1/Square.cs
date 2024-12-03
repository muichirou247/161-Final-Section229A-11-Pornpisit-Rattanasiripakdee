using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    void Start()
    {
        side = 6;
        CalculateArea();
        Draw();
        Resize();
        
    }

   
    public override float CalculateArea()
    {
        side = side * side;

        return side;
    }

    public override void Resize()
    {
        Debug.Log("Side Resize in Square Class");

        Debug.Log("Square Side : 6");

        Debug.Log($" Square Area : {side} ");
    }

    public override void Draw()
    {
        Debug.Log("Drawing Square");

        Debug.Log("Resize Shape");
    }
}
