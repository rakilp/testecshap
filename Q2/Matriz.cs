using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Matriz
    {
        static void Main(string[] args)
        {
            
            int n,i,j;

            do
            {
                Console.WriteLine("Digite o número de entrada da matriz");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n > 0);


            int[,] matriz = new int[n,n];

            for (i = 0; i < n; i++)
            {
                for(j=0; j<n; j++)
                {
                    if (i == j)
                    {
                        matriz[i, j] = 1;
                        Console.Write(matriz[i, j]);

                    }
                    else
                    {
                        matriz[i, j] = 0;
                        Console.Write(matriz[i, j]);
                    }


                }

                Console.WriteLine("");
            }



            Console.WriteLine("");
            Console.Write("Aperte Enter para sair");
            Console.ReadLine();

        }

    }
}
