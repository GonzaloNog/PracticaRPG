using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arponero : Character
{
    public Arponero(string name) : base(name, 20, Resources.Load<Sprite>("Sprite/Arponero"))
    {

    }
    public override float Heal()
    {
        Debug.Log("El Arponero se cura");
        health += 22;
        base.Heal();
        return 22;
    }
    public override float Attack()
    {
        Debug.Log("El Arponero ataca " );
        return Random.Range(damage, damage * 2f);
    }
}