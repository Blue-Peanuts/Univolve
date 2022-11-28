using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OrganType
{
    Booster
}

public abstract class Organ
{
    protected Cell Cell;

    public abstract float Input();
    public abstract void Output();

    public static Organ CreateOrgan(OrganType organType)
    {
        Dictionary<OrganType, Organ> organs = new Dictionary<OrganType, Organ>
        {
            [OrganType.Booster] = new Booster()
        };

        return organs[organType];
    }

    public void SetCell(Cell cell) => Cell = cell;
}
