using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{


     void Start()
    {
        Cast();       
    }

    public override void Cast()
    {
        Debug.Log("Casting a Fireball spell!! Burn them all ");
        Debug.Log($"Casting a spell on terget : Monster ");
        Debug.Log($"Casting a spell on : Monster! with power level : 5 ");
    }
    public void Cast(string newString)
    {
        newString = "Monster";

        Debug.Log($"Casting a spell on terget : {newString} ");
    }

    public void Cast(string newString, int Newint)
    {
        Newint = 5;

        Debug.Log($"Casting a spell on : {newString}! with power level : {Newint} ");
    }
}
