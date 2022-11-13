using System.Collections.Generic;

public class NeuralNetwork : ITick
{
    private readonly List<Neuron> _neurons;
    private readonly List<Axon> _axons;

    public NeuralNetwork(List<Neuron> neurons, List<Axon> axons)
    {
        _neurons = neurons;
        _axons = axons;
    }
    
    public void Tick(float deltaTime)
    {
        foreach (var neuron in _neurons)
            neuron.Tick(deltaTime);
        foreach (var axon in _axons)
            axon.Tick(deltaTime);
    }
}
