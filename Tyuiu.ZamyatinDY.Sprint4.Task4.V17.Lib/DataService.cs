using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZamyatinDY.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int columns = matrix.Length / rows;

            int summatx = 0;

            for(int i = 0; i < rows;i++)
            {
                for(int j = 0;j<columns;j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        summatx += matrix[i, j];
                    }
                }
            }
            return summatx;
        }
    }
}
