using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{

    public float saturation;
    public bool isYummy;

    public override void Use()
    {

    }

    /*public override void UseText()
    {

    }*/

    public override string ToString()
    {
        return base.ToString();
    }

    /*public string YummyToString()
    {

    }*/
}
