using UnityEngine;
public class Cell
{
    private readonly NeuralNetwork _neuralNetwork;
    private readonly Genes _genes;
    private readonly GameObject _cellGameObject;
    public Cell(Genes genes, Vector3 position, Quaternion rotation)
    {
        _genes = genes;
        _cellGameObject = Object.Instantiate(Overseer.Instance.cellPrefab, position, rotation);
    }
}