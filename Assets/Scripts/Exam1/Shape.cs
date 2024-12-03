using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour 
{
    protected string shapeName;

    void Start()
    {
    
    }
    public void Init(string Area)
    {
        
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        
    }
    public virtual void Draw()
    {

    }
}
