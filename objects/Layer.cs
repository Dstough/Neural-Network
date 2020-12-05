using Neural_Network.Core;

namespace Neural_Network.Objects
{
    internal class Layer
    {
        internal double[] Inputs { get; set; }
        internal double[,] Weights { get; set; }
        internal double[] Biases { get; set; }
        internal double[] Outputs { get; set; }

        internal Layer(int inputSize, int outputSize, double defaultValue = 0.0)
        {
            Inputs = new double[inputSize];
            Outputs = new double[outputSize];
            Biases = new double[outputSize];
            Weights = new double[outputSize, inputSize];

            for (var i = 0; i < inputSize; i++)
                Inputs[i] = defaultValue;

            for (var o = 0; o < outputSize; o++)
            {
                Outputs[o] = defaultValue;
                Biases[o] = defaultValue;

                for (var i = 0; i < inputSize; i++)
                    Weights[o, i] = defaultValue;
            }
        }

        internal void calculateOutput()
        {
            Outputs = MatrixMath.Resultant(MatrixMath.DotProduct(Weights, Inputs), Biases);
        }
    }
}
