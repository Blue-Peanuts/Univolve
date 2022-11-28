using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumper : Organ
{
    public Pumper(Vector3 organPosition) : base(organPosition)
    {
    }

    public override float Input()
    {
        return 100;
    }

    public override void Output()
    {
    }
}
