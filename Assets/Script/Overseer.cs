using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overseer : MonoBehaviour
{
    public static Overseer Instance;
    public GameObject cellPrefab;

    private void Start()
    {
        Instance = this;
    }
}
