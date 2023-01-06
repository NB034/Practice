using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Matrix
    {
        int[,] matrix;
        Random random = new Random();

        public Matrix()
        {
            matrix = new int[0, 0];
        }

        public Matrix(int i, int j)
        {
            matrix = new int[i, j];
        }

        public Matrix(int i, int j, int value)
        {
            matrix = new int[i, j];
            fill(value);
        }

        public int i
        {
            get { return matrix.GetLength(0); }
        }

        public int j
        {
            get { return matrix.GetLength(1); }
        }

        public int getElement(int i, int j)
        {
            if (i < 0 || j < 0 || i > matrix.GetLength(0) || j > matrix.GetLength(1))
                throw new Exception("Wrong index.");
            return matrix[i, j];
        }

        public void setElement(int i, int j, int value)
        {
            if (i < 0 || j < 0 || i > matrix.GetLength(0) || j > matrix.GetLength(1))
                throw new Exception("Wrong index.");
            matrix[i, j] = value;
        }

        public void fill()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"Enter the {i + 1} row: ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadKey().KeyChar - '0');
                }
            }
        }

        public void fill(int value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value;
                }
            }
        }

        public void autoFill(int? maxValue = null, int? minValue = null)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxValue == null)
                        matrix[i, j] = random.Next();
                    else if (minValue == null)
                        minValue = random.Next((int)maxValue);
                    else
                        maxValue = random.Next((int)minValue, (int)maxValue);
                }
            }
        }

        public int getMin()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }
            return min;
        }

        public int getMax()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }
            return max;
        }
    }
}
