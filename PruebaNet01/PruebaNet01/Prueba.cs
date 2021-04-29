using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaNet01
{
    public class Prueba
    {
        public static int[] CompletaRango(int[] Array)
        {
            int[] ArrayResult;

            if (Array.Count() > 1)
            {
                int iMax = Array.Max();
                int iMin = Array.Min();

                ArrayResult = new int[(iMax - iMin) + 1];
                int x = 0;
                for (int i = iMin; i <= iMax; i++)
                {
                    ArrayResult[x] = i;
                    x++;
                }

                return ArrayResult;
            }
            else
            {
                return null;
            }
        }
    }
}
