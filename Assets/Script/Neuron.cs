using System.Collections.Generic;

public class Neuron
{
    const float A = 0.02f, B = 0.2f, C = -65, D = 2;
    const float VT = 30;

    List<Axon> _axons;
    private float _v = VT;
    private float _u = D;
    private float _i;
    private float VPrime => 0.04f * _v * _v + 5 * _v + 140 - _u + _i;
    private float UPrime => A * (B * _v - _u);
    public Neuron(List<Axon> axons)
    {
        _axons = axons;
    }
    private void Update()
    {
        if (_v >= VT)
            Spike();

    }
    private void Spike()
    {
        foreach (Axon axon in _axons)
        {
            axon.Transfer();
        }
        _v = C;
    }
}