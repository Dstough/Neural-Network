using System;
using Neural_Network.Core;
using Neural_Network.Objects;

namespace Neural_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            var layer = new Layer(3, 4);
            layer.Inputs = new double[] { 1, 2, 3, 2.5 };
            layer.Biases = new double[] { 2, 3, 0.5 };
            layer.Weights = new double[,]
            {
                {   0.2,   0.8, -0.5,  1.0 },
                {   0.5, -0.91, 0.26, -0.5 },
                { -0.26, -0.27, 0.17, 0.87 },
            };
            layer.calculateOutput();

            foreach (var item in layer.Outputs)
                Console.Write($"{item}  ");
        }
    }
}