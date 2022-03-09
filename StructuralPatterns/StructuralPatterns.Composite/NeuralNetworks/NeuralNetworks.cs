using NeuralNetworks.Classes;

namespace NeuralNetworks
{
    public class NeuralNetworks
    {
        static void Main(string[] args)
        {
            Neuron neuron1 = new Neuron();
            Neuron neuron2 = new Neuron();

            neuron1.ConnectTo(neuron2);

            NeuronLayer layer1 = new NeuronLayer();
            NeuronLayer layer2 = new NeuronLayer();

            neuron1.ConnectTo(layer1);
            layer1.ConnectTo(layer2);
        }
    }
}
