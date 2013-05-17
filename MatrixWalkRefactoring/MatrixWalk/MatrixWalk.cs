namespace MatrixWalk
{
    using System;
    using System.Linq;

    public class MatrixWalk
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number to determine the matrix size:");
            string inputNumber = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(inputNumber, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("Please enter a valid number in the range [1, 100]");
                inputNumber = Console.ReadLine();
            }

            int[,] matrix = new int[n, n];
            int currentNumber = 1;
            int row = 0, col = 0;

            while (Matrix.IsNotVisited(matrix, out row, out col))
            {
                int dx = 1;
                int dy = 1;
                while (true)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;

                    if (!Matrix.IsTrapped(matrix, row, col))
                    {
                        while (row + dx >= n || row + dx < 0 || col + dy >= n || col + dy < 0 || matrix[row + dx, col + dy] != 0)
                        {
                            Matrix.ChangeDirection(ref dx, ref dy);
                        }
                    }
                    else
                    {
                        break;
                    }

                    row += dx;
                    col += dy;
                }
            }
            MatrixPrinter.PrintMatrix(matrix);
        }
    }
}