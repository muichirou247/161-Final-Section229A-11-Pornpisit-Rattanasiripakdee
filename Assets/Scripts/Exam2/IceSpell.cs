using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Cast();
           
    }

    public override void Cast()
    {
        Debug.Log("Casting an Ice shard spell! Freeze the Enemy! ");
        Debug.Log($"Casting a spell on terget : Enemy ");
        Debug.Log($"Casting a spell on : Enemy! with power level : 7 ");
    }
    public void Cast(string newString)
    {
        newString = "Enemy";

        Debug.Log($"Casting a spell on terget : {newString} ");
    }

    public void Cast(string newString, int Newint)
    {
        Newint = 7;

        Debug.Log($"Casting a spell on : {newString}! with power level : {Newint} ");
    }
}

