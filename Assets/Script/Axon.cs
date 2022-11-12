using System.Collections.Generic;

public class Axon : ITick
{
    const float I_MULTIPLIER = 200;

    private Neuron _output;
    private float _weight;

    private bool _stimulated = false;

    public Axon(Neuron output, float weight)
    {
        _output = output;
        _weight = weight;
    }
    public void Tick(float deltaTime)
    {
        if (_stimulated)
            _output.Charge(I_MULTIPLIER * _weight);
    }
    public void Stimulate()
    {
        _stimulated = true;
    }
}