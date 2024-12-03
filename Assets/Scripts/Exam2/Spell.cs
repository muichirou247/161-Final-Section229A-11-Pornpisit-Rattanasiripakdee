using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("Spell-Cassting Simulation Started");
        Debug.Log("Casting a generic spell");
    }

    public  void Cast(string newString)
    {

    }

    public  void Cast(string newString, int Newint)
    {

    }
}
