using System.Collections.Generic;
using UnityEngine;
public class Neuron
{
    const float A = 0.02f, B = 0.2f, C = -65, D = 2;
    const float VT = 30;

    private List<Axon> _axons;
    private float _v = VT;
    private float _u = D;
    private float _i = 0;
    private float VPrime => 0.04f * _v * _v + 5 * _v + 140 - _u + _i;
    private float UPrime => A * (B * _v - _u);
    private float GetDeltaV(float deltaTime) => VPrime * deltaTime;
    private float GetDeltaU(float deltaTime) => UPrime * deltaTime;

    public Neuron(List<Axon> axons)
    {
        _axons = axons;
    }
    private void Update(float deltaTime)
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
        foreach (Axon axon in _axons)
        {
            axon.Signal();
        }
    }
}