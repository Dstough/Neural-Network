using System;
using System.Collections.Generic;

namespace Neural_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            var layerOutput = new List<double>();
            var layerInputs = new double[] { 1, 2, 3, 2.5 };
            var layerBiases = new double[] { 2, 3, 0.5 };
            var layerWeights = new double[,]
            {
                {   0.2,   0.8, -0.5,  1.0 },
                {   0.5, -0.91, 0.26, -0.5 },
                { -0.26, -0.27, 0.17, 0.87 },
            };

            var output = DotProduct(layerWeights, layerInputs);
            output = Resultant(output, layerBiases);

            foreach (var item in output)
                Console.Write($"{item}  ");
        }

        static double[] Resultant(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new Exception("Shape Error: The two provided arrays are not the same length.");

            var output = new double[vector1.Length];

            for (var index = 0; index < vector1.Length; index++)
                output[index] = vector1[index] + vector2[index];

            return output;
        }

        static double[] DotProduct(double[,] matrix, double[] vector)
        {
            if (matrix.GetLength(1) != vector.Length)
                throw new Exception("Shape Error: The provided matrix size doesn't match the vector size.");

            var output = new double[matrix.GetLength(0)];

            for (var index = 0; index < matrix.GetLength(0); index++)
            {
                output[index] = 0;

                for (var subIndex = 0; subIndex < matrix.GetLength(1); subIndex++)
                    output[index] += matrix[index, subIndex] * vector[subIndex];
            }

            return output;
        }
    }
}