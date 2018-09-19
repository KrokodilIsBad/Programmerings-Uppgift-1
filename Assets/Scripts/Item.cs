using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string displayName;
    public float cost;
    public float weight;

    public float GetCostPerKilo()
    {
        return cost / weight;

    }

    public override string ToString()
    {
        return "Item Name: " + displayName + " Cost: " + cost.ToString() + " Weight: " + weight.ToString() + " Cost Per Kilo: " + GetCostPerKilo().ToString();
    }

    public virtual void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
}
