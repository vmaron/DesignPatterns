using System.Collections.ObjectModel;

namespace Structural.Composite.NeuralNetworks.Models
{
    public class NeuronLayer : Collection<Neuron>
    {
        public virtual string Name { get; set; } = "Layer";
    }
}