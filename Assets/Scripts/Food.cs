using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{

    public float saturation;
    public bool isYummy;

    public override void Use()
    {
        if (uses < maxUses)
        {
            Debug.Log(UseText());
            uses++;
        }
        else
        {
            NoUsesRemainingText();
        }
    }

    public override string UseText()
    {
        return "Consumed " + displayName + ". " + YummyToString();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public string YummyToString()
    {
        if (isYummy)
        {
            return "Food is yummy!";
        }
        else
        {
            return "Food isn't yummy!";
        }
    }
}
