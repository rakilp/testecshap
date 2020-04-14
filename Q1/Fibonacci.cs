using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Fibonacci {
        static void Main(string[] args)
        {

            int t, i;
            long[] Fib;

           

                Console.WriteLine("Digite o número de Fib's para consultar");
                t = Convert.ToInt32(Console.ReadLine());
           

                Fib = new Int64[t];

            for (i = 0; i < t; i++)
            {
                Console.WriteLine("Digite o número " + (i + 1));
                Fib[i] = Convert.ToInt64(Console.ReadLine());

            }

            for(i=0; i< t; i++)
            {
                Console.WriteLine("F(" + Fib[i] + ") = " + Calcfib(Fib[i]));

            }

            Console.WriteLine("Aperte Enter para sair");
            Console.ReadLine();

        }

        static long Calcfib (long i)
        {
            if(i == 0)
            {
                return 0;
            }else if(i == 1)
            {
                return 1;
            }
            else if(i == 2)
            {
                return 1;
            }
            else
            {
                return Calcfib(i - 1) + Calcfib(i - 2);
            }
                
        }

       
    }
}
