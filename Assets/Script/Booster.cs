using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : Organ
{
    public override float Input()
    {
        return 0;
    }

    public override void Output()
    {
        
    }

    public Booster(Vector3 organPosition) : base(organPosition)
    {
    }
}
