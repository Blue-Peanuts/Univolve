using System.Collections.Generic;
using UnityEngine;
public class Cell
{
    private float _health = 100;
    
    private readonly NeuralNetwork _neuralNetwork;
    private readonly Genes _genes;
    public readonly GameObject GameObject;
    private readonly List<Organ> _organs;
    
    public Cell(Genes genes, Vector3 position, Quaternion rotation)
    {
        _genes = genes;
        GameObject = Object.Instantiate(Overseer.Instance.cellPrefab, position, rotation);
        _neuralNetwork = _genes.BuildNeuralNetwork();
        _organs = _neuralNetwork.GetOrgans();
        foreach (var organ in _organs)
        {
            organ.SetCell(this);
        }
    }
}