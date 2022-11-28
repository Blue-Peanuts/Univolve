using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum OrganType
{
    Booster
}

public abstract class Organ
{
    protected Cell Cell;
    protected Vector3 OrganPosition;

    public abstract float Input();
    public abstract void Output();

    public Organ(Vector3 organPosition)
    {
        OrganPosition = organPosition;
    }
    
    public static Organ CreateOrgan(OrganType organType, Vector3 organPosition)
    {
        Dictionary<OrganType, Organ> organs = new Dictionary<OrganType, Organ>
        {
            [OrganType.Booster] = new Booster(organPosition)
        };

        return organs[organType];
    }

    public void SetCell(Cell cell) => Cell = cell;
}