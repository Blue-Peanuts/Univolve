using System.Collections.Generic;

public class NeuralNetwork : ITick
{
    List<Neuron> _neurons;
    List<Axon> _axons;

    public void Tick(float deltaTime)
    {
        foreach (Neuron neuron in _neurons)
            neuron.Tick(deltaTime);
        foreach (Axon axon in _axons)
            axon.Tick(deltaTime);
    }
}
