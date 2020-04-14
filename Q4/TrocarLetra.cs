using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class TrocarLetra
    {
        static void Main(string[] args)
        {
            string[] palavra;
            char[] letra;
            char[] letrasdiferente;
            int t,i,j,x,cont;

            Console.WriteLine("Digite a quantidade de palavras:");
            t=Convert.ToInt32(Console.ReadLine());

            palavra = new string[t];
            letra = new char[t];


            for (i = 0; i < t; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "° palavra:");
                 palavra[i]=Console.ReadLine().ToUpper();

                Console.WriteLine("Digite a " + (i + 1) + "° letra:");
                letra[i] = Convert.ToChar(Console.ReadLine().ToUpper());

            }


            for(x=0; x < t; x++){

                for (i = 0; i < palavra[x].Length; i++)
                {
                  
                    cont = 1;
                    for (j = i+1; j < palavra[x].Length; j++)
                    {

                        if (palavra[x][i].Equals(palavra[x][j]) )
                        {
                            cont++;

                        }

                    }

                    letrasdiferente = new char[palavra[x].Length];

                    if (cont == 1)
                    {
                        Console.Write(palavra[x][i] + "(" + Cont(palavra[x][i],palavra[x]) + "); ");
                        
                    }


                }

                Console.WriteLine();
                
                if (Cont(letra[x], palavra[x])==0)
                {
                    
                    Console.WriteLine(0);
                }
                else
                {
                    
                    Console.WriteLine(Cont(letra[x], palavra[x]));
                }

            }






            Console.WriteLine("Aperte Enter para sair");
            Console.ReadLine();

        }

        static string Vencedor(int i)
        {
            if (i == 1)
            {
                return "Bazinga!";
            }
            else
            {
                return "Raj trapaceou!";
            }


        }
        static int Cont (char letra, string palavra)
        {
            int i,cont=0;

            for (i = 0; i < palavra.Length; i++)
            {

                if (letra.Equals(palavra[i]))
                {
                    cont++;
                }
                

            }

            return cont;


        }
        



    }
}
