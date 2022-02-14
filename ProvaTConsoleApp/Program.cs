using System;

namespace ProvaTConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                String opcao;
                do
                {
                    int X, Y, Z;

                    Console.WriteLine(" digite 1 para verificar o tipo de triângulo: ");
                    Console.WriteLine(" digite S para sair");
                    opcao = Console.ReadLine();


                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine(" insira o valor de X: ");
                            X = int.Parse(Console.ReadLine());

                            Console.WriteLine(" insira o valor de Y: ");
                            Y = int.Parse(Console.ReadLine());

                            Console.WriteLine(" insira o valor de Z: ");
                            Z = int.Parse(Console.ReadLine());

                            if (X < 0 || Y < 0 || Z < 0)
                                Console.WriteLine(" não existe lado negativo");


                            if (X + Y > Z && X + Z > Y && Y + Z > X)
                            {
                                Console.WriteLine(" existe um triângulo ");

                                if (X == Y && Y == Z)
                                    Console.WriteLine(" triângulo equilátero ");
                                else if (X == Y && X == Z && Y == Z)
                                    Console.WriteLine(" triângulo isósceles ");
                                else
                                    Console.WriteLine(" triângulo escaleno ");


                            }
                            else Console.WriteLine(" trângulo inválido ");

                            break;
                        case "S":
                            break;

                    }

                }
                while (opcao == "1");
            }
        }
    }

