using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class BigBagTheory
    {
        static void Main(string[] args)
        {
            string[] jogada;            
            int t, i,j, cont=0;
            string[] aux;
            char[] Separators = new char[] {' '};

            
                Console.WriteLine("Digite a quantidade :");
                t = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();


            Console.WriteLine();

            jogada = new string[t*2];

            for (i = 0; i < t; i++)
            {
               Console.WriteLine("Digite a palavra : ");
              aux= Console.ReadLine().ToUpper().Split(' ');
                
                for (j=0; j < 2; j++)
                {
                    jogada[cont] = aux[j];
                    cont++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();



            j = 0;
            for (i = 0; i < cont; i++)
            {
                
                if (i%2 == 0 || i==0)
                {
                    
                    if (jogada[i].Equals("PEDRA"))
                    {
                        //CASO IMPAR == PEDRA
                        j++;
                        Console.WriteLine("Caso #" + j  + ": " + Vencedor(Pedra(jogada[i+1])));

                        
                    }
                    else if (jogada[i].Equals("PAPEL"))
                    {
                        //CASO IMPAR == PAPEL

                        j++;
                        Console.WriteLine("Caso #" + j + ": " + Vencedor(Papel(jogada[i+1])));
                        

                    }
                    else if (jogada[i].Equals("TESOURA"))
                    {//CASO IMPAR == TESOURA
                        j++;
                        Console.WriteLine("Caso #" + j + ": " + Vencedor(Tesoura(jogada[i+1])));
                        

                    }
                    else if (jogada[i].Equals("LAGARTO"))
                    {//CASO IMPAR == LAGARTO
                        j++;
                        Console.WriteLine("Caso #" + j + ": " + Vencedor(Lagarto(jogada[i+1])));
                        

                    }
                    else
                    {
                        //CASO IMPAR == SPOCK
                        j++;
                        Console.WriteLine("Caso #" + j + ": " + Vencedor(Spock(jogada[i +1])));
                        
                    }


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


        static int Pedra(string jogada)
        {
            if (jogada.Equals("LAGARTO") || jogada.Equals("TESOURA"))
            {
                return 1;
            }
            else
            {
                return 0;

            }

        }

        static int Papel(string jogada)
        {
            if (jogada.Equals("PEDRA") || jogada.Equals("SPOCK"))
            {
                return 1;
            }
            else
            {
                return 0;

            }
        }

        static int Tesoura(string jogada)
        {
            if (jogada.Equals("PAPEL") || jogada.Equals("LAGARTO"))
            {
                return 1;
            }
            else
            {
                return 0;

            }
        }

        static int Lagarto(string jogada)
        {
            if (jogada.Equals("SPOCK") || jogada.Equals("PAPEL"))
            {
                return 1;
            }
            else
            {
                return 0;

            }
        }

        static int Spock(string jogada)
        {
            if (jogada.Equals("PEDRA") || jogada.Equals("TESOURA"))
            {
                return 1;
            }
            else
            {
                return 0;

            }

        }
    }
}

