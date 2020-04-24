using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3analiza.components
{
    //2.zad
    class MatrixGenerator
    {
        public static MatrixGenerator instance;
        private Random random;

        private MatrixGenerator()
        {
            random = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public float[][] CreateMatrix(int rows, int cols)
        {
            float[][] matrix = new float[cols][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new float[rows];
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i][j] = (float)random.NextDouble();
                }
            }
            return matrix;
        }
    }
}
