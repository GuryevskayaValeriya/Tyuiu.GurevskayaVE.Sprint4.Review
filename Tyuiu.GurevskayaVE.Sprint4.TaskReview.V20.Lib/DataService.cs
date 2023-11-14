using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GurevskayaVE.Sprint4.TaskReview.V20.Lib
{
    public class DataService
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mas = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int s = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] % 2 == 0) s*=mas[i,j];
                }
            }
            return s;

        }
    }
}
