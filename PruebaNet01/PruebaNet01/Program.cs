using System;
using System.Linq;

namespace PruebaNet01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] Array01 = { 2, 1, 4, 5 };
            int[] Array02 = { 100, 96, 101, 102, 105};
            int[] Array03 = { 22, 25 };


            Prueba.CompletaRango(Array01);

            CompletaRango(Array01);
            CompletaRango(Array02);
            CompletaRango(Array03);

            Console.ReadKey();
        }

        public static void CompletaRango(int[] Array)
        {

            if (Array.Count() > 1)
            {
                int iMax = Array.Max();
                int iMin = Array.Min();

                Console.Write("[");
                for (int i = iMin; i <= iMax; i++)
                {
                    if (i == iMax)
                    {
                        Console.Write(i.ToString() + "]");
                    }
                    else
                    {
                        Console.Write(i.ToString() + ", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
