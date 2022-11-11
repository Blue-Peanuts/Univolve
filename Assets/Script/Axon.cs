using System.Collections.Generic;

public class Axon
{
    const float I_MULTIPLIER = 200;

    private Neuron _output;
    private float _weight;

    public Axon(Neuron output, float weight)
    {
        _output = output;
        _weight = weight;
    }
    public void Signal()
    {
        _output.Charge(I_MULTIPLIER * _weight);
    }
}