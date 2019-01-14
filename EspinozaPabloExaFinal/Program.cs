using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspinozaPabloExaFinal
{
    

    class Program
        
    {
        const int MAX = 10;

        public static void Main(string[] args)
        {
            int[] x = new int[MAX];
            int Dem = 0;
            int[,] D = new int[5, 5];
            int[] valores = new int[MAX];
            Leer(x);
            Imprime(x);
            Suma(x);
            Dem = Suma(x);
            Console.WriteLine("\n La suma Total es: {0}", Dem);

            Console.ReadKey();


            int X = 0;
            int Y = 0;
            int Z = 0;
            string Cad;

            

            Console.Write("\n**ELIJA EL TAMAÑO DE SU MATRIZ**: ");
            Cad = Console.ReadLine();
            Z = int.Parse(Cad);
            int[,] MAT = new int[100, 100];

            int[,] MATT = new int[Z + 1, Z + 1];
            Random rnd = new Random();
            for (X = 1; X <= Z; X++)
            {
                for (Y = 1; Y <= Z; Y++)
                {
                    MAT[X, Y] = rnd.Next(0, 50);
                    Console.SetCursorPosition(Y * 4, X + 1);
                    Console.Write(MAT[X, Y]);
                }
            }

            for (X = 1; X <= Z; X++)
            {
                for (Y = 1; Y <= Z; Y++)
                {
                    MATT[X, Y] = MAT[Y, X];
                }
            }

            for (X = 1; X <= Z; X++)
            {
                for (Y = 1; Y <= Z; Y++)
                {
                    Console.SetCursorPosition(Y * 4, X + 10);
                    Console.Write(MATT[X, Y]);
                }
            }
            Console.WriteLine();
            Console.Write("\n+Pulse una Letra para Continuar:");
            Console.ReadLine();
        }





        public static void Leer(int[] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                x[i] = i;
            }

        }
        public static void Imprime(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("\n El valor {0} es {1}", i, x[i]);

            }


        }
        public static int Suma(int[] x)
        {
            int Sum = 0, Multi, SumPorm = 0, Por, Tot;
            for (int i = 0; i < x.Length; i++)
            {
                
                if (x[i] % 2 == 0)
                {
                    Multi = x[i] * 10;
                    Sum = Sum + Multi;
                }
                else
                {
                    Por = x[i] * x[i];
                    SumPorm = SumPorm + Por;
                }

            }
            Tot = Sum + SumPorm;
            return Tot;

        }

    }
}
