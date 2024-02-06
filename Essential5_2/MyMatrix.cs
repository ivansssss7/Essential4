using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5_2
{
    class MyMatrix
    {
        private int[,] matrix = null;

        public int NumberOfCols { get; set; }
        public int NumberOfRows { get; set; }

        public MyMatrix(int numberOfCols, int numberOfRows)
        {
            NumberOfCols = numberOfCols;
            NumberOfRows = numberOfRows;
            matrix = new int[numberOfCols, numberOfRows];
        }
        public void ChangeSizeOfMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Values can not be negative");
            }
            else
            {
                NumberOfCols = x;
                NumberOfRows = y;
                matrix = new int[NumberOfCols, NumberOfRows];
            }
        }
        public void FeedMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < NumberOfCols; i++)
            {
                for (int j = 0; j < NumberOfRows; j++)
                {
                    matrix[i, j] = rand.Next(30, 99);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < NumberOfCols; i++)
            {
                for (int j = 0; j < NumberOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int col, int row]
        {
            set
            {
                if ((col > 0 && row > 0) && (col < NumberOfCols && row < NumberOfRows))
                    matrix[col, row] = value;
                else
                    Console.WriteLine("Incorrect values of indexes {0} и {1}", col, row);
            }
            get
            {
                return matrix[col, row];
            }
        }
    }
}
