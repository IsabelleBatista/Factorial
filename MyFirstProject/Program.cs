using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um n° para calular o fatorial ou S para Sair: ");
                Console.WriteLine();
                string opcao = Console.ReadLine();

                if (opcao == "s" || opcao == "S")
                    break;

                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if (valor == 0)
                        Console.WriteLine("0! = 1 \n");
                    else if (valor < 0)
                        Console.WriteLine("Não foi possivel calcular \n");
                    else
                    {
                        int resultado = 1;
                        Console.Write(valor + "! = ");
                        for (int i = valor; i > 0; i--)
                        {
                            resultado *= i;
                            if (i == 1)
                            {
                                Console.Write(i + " = " + resultado);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write(i + "x");
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    char presskey = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                }
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}