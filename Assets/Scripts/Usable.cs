using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{

    public float uses;
    public float maxUses = 3;

    public void OnMouseUpAsButton()
    {

    }

    public virtual void Use()
    {

    }

    /*public virtual string UseText()
    {

    }

    public string NoUsesRemainingText()
    {

    }*/

    public override string ToString()
    {
        return base.ToString();
    }
}
