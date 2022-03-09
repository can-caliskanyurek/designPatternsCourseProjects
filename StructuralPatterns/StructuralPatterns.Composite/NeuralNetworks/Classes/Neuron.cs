using System.Collections;
using System.Collections.Generic;

namespace NeuralNetworks.Classes
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;
        public List<Neuron> In = new List<Neuron>();
        public List<Neuron> Out = new List<Neuron>();


        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
