using System;
using System.Collections;
using System.Collections.Generic;

namespace Structural.Composite.NeuralNetworks.Models
{
    public class Neuron : IEnumerable<Neuron>
    {
        public virtual string Name { get; set; } = "Neuron";
        private readonly Lazy<List<Neuron>> _in = new Lazy<List<Neuron>>();
        private readonly Lazy<List<Neuron>> _out = new Lazy<List<Neuron>>();

        public float Value;
        public List<Neuron> In => _in.Value;
        public List<Neuron> Out => _out.Value;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}