using System.Collections.Generic;

public class Axon
{
    private Neuron _output;
    private float _resistence;

    public Axon(Neuron output, float resistence)
    {
        _output = output;
        _resistence = resistence;
    }
    public void Transfer()
    {

    }
}