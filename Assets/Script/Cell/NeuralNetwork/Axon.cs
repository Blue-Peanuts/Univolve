using System.Collections.Generic;

public class Axon : ITick
{
    private const float Multiplier = 200;

    private readonly Neuron _output;
    private readonly float _weight;

    private bool _stimulated = false;

    public Axon(Neuron output, float weight)
    {
        _output = output;
        _weight = weight;
    }
    public void Tick(float deltaTime)
    {
        if (_stimulated)
            _output.Charge(Multiplier * _weight);
    }
    public void Stimulate()
    {
        _stimulated = true;
    }
}