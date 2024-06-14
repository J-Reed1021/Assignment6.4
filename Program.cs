namespace Assignment6._4
{
    using System;

    class Program
    {
        static void Rotate90Clockwise(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            // Reverse each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n - 1 - j];
                    matrix[i, n - 1 - j] = temp;
                }
            }
        }

        static void Main()
        {
            int[,] matrix = { { 1, 2, 3 },
                              { 4, 5, 6 },
                              { 7, 8, 9 } };



            Rotate90Clockwise(matrix);

            // Print the rotated matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}