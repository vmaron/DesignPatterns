using Structural.Composite.NeuralNetworks.Models;

namespace Structural.Composite.NeuralNetworks
{
    public class Demo
    {
        private static void Main(string[] args)
        {
            var neuron1 = new Neuron {Name = "Neuron1"};
            var neuron2 = new Neuron {Name = "Neuron2"};
            var layer1 = new NeuronLayer {Name = "Layer1"};
            var layer2 = new NeuronLayer {Name = "Layer2"};

            layer1.Add(neuron1);
            neuron2.ConnectTo(neuron1); //Neuron1 => Neuron2 (In) / Neuron2 => Neuron1 (Out) 

            //The same as

            //layer1.Add(neuron1);
            //layer2.Add(neuron2);
            //layer1.ConnectTo(layer2);
        }
    }
}