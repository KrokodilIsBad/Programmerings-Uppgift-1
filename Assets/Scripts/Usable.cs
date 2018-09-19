using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{

    public float uses;
    public float maxUses = 3;

    public void OnMouseUpAsButton()
    {
        Use();
    }

    public virtual void Use()
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

    public virtual string UseText()
    {
        return "Consumed " + displayName + ", it was tasty.";
    }

    public string NoUsesRemainingText()
    {
        return "Out of " + displayName;
    }

    public override string ToString()
    {
        return "Item Name: " + displayName + " Cost: " + cost.ToString() + " Weight: " + weight.ToString() + " Cost Per Kilo: " + GetCostPerKilo().ToString() + " Uses: " + uses + "/" + maxUses;
    }
}
