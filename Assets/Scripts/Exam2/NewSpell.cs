using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpell : Spell
{
    void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        Debug.Log("Casting a Magic Spell! Attack all ");
        Debug.Log($"Casting a spell on terget : Curse ");
        Debug.Log($"Casting a spell on : Curse! with power level : 10 ");
    }
    public void Cast(string newString)
    {
        newString = "Curse";

        Debug.Log($"Casting a spell on terget : {newString} ");
    }

    public void Cast(string newString, int Newint)
    {
        Newint = 10;

        Debug.Log($"Casting a spell on : {newString}! with power level : {Newint} ");
    }
}

