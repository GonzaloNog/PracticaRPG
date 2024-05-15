using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolero : Character
{
    public Pistolero(string name, Sprite img) : base(name, 35, img)
    {

    }
    public override float Heal()
    {
        Debug.Log("El Pistolero se cura");
        health += 15;
        base.Heal();
        return 15;
    }
    public override float Attack()
    {
        Debug.Log("El Pistolero ataca ");
        return Random.Range(damage, damage * 2.2f);
    }

}
