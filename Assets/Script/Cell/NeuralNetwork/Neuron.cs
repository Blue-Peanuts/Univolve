using System.Collections.Generic;

public class Neuron : ITick
{
    private const float A = 0.02f, B = 0.2f, C = -65, D = 2;
    private const float VT = 30;
    
    private List<Axon> _axons = new List<Axon>();
    
    private float _v = VT;
    private float _u = D;
    private float _i = 0;
    private float VPrime => 0.04f * _v * _v + 5 * _v + 140 - _u + _i;
    private float UPrime => A * (B * _v - _u);
    private float GetDeltaV(float deltaTime) => VPrime * deltaTime;
    private float GetDeltaU(float deltaTime) => UPrime * deltaTime;

    public void AddAxon(Axon axon)
    {
        _axons.Add(axon);
    }
    
    public void Tick(float deltaTime)
    {
        _v += GetDeltaV(deltaTime);
        _u += GetDeltaU(deltaTime);

        if (_v >= VT)
        {
            Spike();
            _v = C;
        }

        _i = 0;
    }
    public void Charge(float i)
    {
        _i += i;
    }
    private void Spike()
    {
        foreach (var axon in _axons)
            axon.Stimulate();
    }
}