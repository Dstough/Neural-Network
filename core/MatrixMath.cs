namespace Neural_Network.Core
{
    internal static class MatrixMath
    {
        internal static double[] Resultant(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ShapeException();

            var output = new double[vector1.Length];

            for (var index = 0; index < vector1.Length; index++)
                output[index] = vector1[index] + vector2[index];

            return output;
        }

        internal static double[] DotProduct(double[,] matrix, double[] vector)
        {
            if (matrix.GetLength(1) != vector.Length)
                throw new ShapeException();

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