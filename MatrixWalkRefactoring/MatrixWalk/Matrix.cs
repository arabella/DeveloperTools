using System;
using System.Linq;

namespace MatrixWalk
{
    public class Matrix
    {
        public static void ChangeDirection(ref int dx, ref int dy)
        {
            const int DirectionTurnsCount = 8;

            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentIndex = 0;

            for (int i = 0; i < DirectionTurnsCount; i++)
            {
                if (directionX[i] == dx && directionY[i] == dy)
                {
                    currentIndex = i;
                    break;
                }
            }

            if (currentIndex == 7)
            {
                dx = directionX[0];
                dy = directionY[0];
            }
            else
            {
                dx = directionX[currentIndex + 1];
                dy = directionY[currentIndex + 1];
            }
        }

        public static bool IsTrapped(int[,] matrix, int x, int y)
        {
            const int DirectionTurnsCount = 8;

            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DirectionTurnsCount; i++)
            {
                if (x + directionX[i] >= matrix.GetLength(0) || x + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (y + directionY[i] >= matrix.GetLength(0) || y + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < DirectionTurnsCount; i++)
            {
                if (matrix[x + directionX[i], y + directionY[i]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsNotVisited(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
