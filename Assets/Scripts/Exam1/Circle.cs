using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circle : Shape
{
    private float radius;

    private void Start()
    {       
        radius = 4f;
        CalculateArea();
        Draw();
        Resize();        
    }

    public override float CalculateArea()
    {
        radius = Mathf.PI * radius * radius;

        return radius;
    }

    public override void Resize()
    {
        Debug.Log("Circle Resize in Circle Class");

        Debug.Log("Circle radius : 4");

        Debug.Log($"Circle Radius : {radius} ");
    }

    public override void Draw()
    {
        Debug.Log($"Drawing Circle ");

        Debug.Log("Resize Shape");
    }

    
}
