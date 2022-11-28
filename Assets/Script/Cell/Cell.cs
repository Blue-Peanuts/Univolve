using System.Collections.Generic;
using UnityEngine;
public class Cell
{
    private readonly NeuralNetwork _neuralNetwork;
    private readonly Genes _genes;
    private readonly GameObject _gameObject;
    private readonly List<Organ> _organs;
    
    public Cell(Genes genes, Vector3 position, Quaternion rotation)
    {
        _genes = genes;
        _gameObject = Object.Instantiate(Overseer.Instance.cellPrefab, position, rotation);
        _neuralNetwork = _genes.BuildNeuralNetwork();
        _organs = _neuralNetwork.GetOrgans();
    }
}