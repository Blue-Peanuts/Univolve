using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public enum FieldDna {
    MutationChance, Size
}

public class Genes
{
    private readonly List<(Guid, OrganType, Vector3)> _neuronsDna;
    private readonly List<(Guid, Guid, float)> _axonsDna;
    private readonly Dictionary<FieldDna, float> _fieldsDna;

    public Genes(List<(Guid, OrganType, Vector3)> neuronsDna, List<(Guid, Guid, float)> axonsDna,
        Dictionary<FieldDna, float> fieldsDna)
    {
        _neuronsDna = neuronsDna;
        _axonsDna = axonsDna;
        _fieldsDna = fieldsDna;
    }
    
    public NeuralNetwork BuildNeuralNetwork()
    {
        var neurons = new List<Neuron>();
        var axons = new List<Axon>();
        var neuronIdPair = new Dictionary<Guid, Neuron>();
        foreach (var (neuronId, organType, organPosition) in _neuronsDna)
        {
            var neuron = new Neuron();
            neuron.AssignOrgan(Organ.CreateOrgan(organType, organPosition));
            neurons.Add(neuron);
            neuronIdPair[neuronId] = neuron;
        }
        foreach (var (from, to, weight) in _axonsDna)
        {
            var axon = new Axon(neuronIdPair[to], weight);
            axons.Add(axon);
            neuronIdPair[from].AddAxon(axon);
        }
        
        return new NeuralNetwork(neurons, axons);
    }
}