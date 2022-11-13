using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genes
{
    private List<Guid> _neuronsDna;
    private List<(Guid, Guid, float)> _axonsDna;

    public NeuralNetwork BuildNeuralNetwork()
    {
        List<Neuron> neurons = new List<Neuron>();
        List<Axon> axons = new List<Axon>();
        Dictionary<Guid, Neuron> neuronIdPair = new Dictionary<Guid, Neuron>();
        foreach (var neuronId in _neuronsDna)
        {
            Neuron neuron = new Neuron();
            neurons.Add(neuron);
            neuronIdPair[neuronId] = neuron;
        }
        foreach (var axonDna in _axonsDna)
        {
            Guid from = axonDna.Item1;
            Guid to = axonDna.Item2;
            float weight = axonDna.Item3;
            
            Axon axon = new Axon(neuronIdPair[to], weight);
            axons.Add(axon);
            neuronIdPair[from].AddAxon(axon);
        }
        
        return new NeuralNetwork(neurons, axons);
    }
}