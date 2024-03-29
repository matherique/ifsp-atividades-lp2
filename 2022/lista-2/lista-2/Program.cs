﻿using System;

namespace lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1_a.Run();
        }
    }

    class EX1_a
    {
        public static void Run()
        {
            int n1 = 0, n2 = 0, n3 = 0;

            Console.Write("Escreva um numero: ");
            string n1Str = Console.ReadLine();
            n1 = int.Parse(n1Str);

            Console.Write("Escreva outro numero: ");
            string n2Str = Console.ReadLine();
            n2 = int.Parse(n2Str);

            Console.Write("Escreva outro numero: ");
            string n3Str = Console.ReadLine();
            n3 = int.Parse(n3Str);

            int[] result = new int[] { n1, n2, n3 };

            Array.Sort(result);

            Console.WriteLine("Os numeros informados em ordem crescente: {0}, {1}, {2}", result[0], result[1], result[2]);
        }
    }

    class EX1_b
    {

        public static void Run()
        {
            double radiano = 0;

            Console.Write("Informe um angulo em radianos: ");
            string radianoStr = Console.ReadLine();
            radiano = double.Parse(radianoStr);

            double PI = 3.14;
            double graus = radiano * (180.0 / PI);

            Console.WriteLine("{0} rad = {1}º", radiano, graus);
        }
    }


    class EX1_c
    {
        public static void Run()
        {

            Console.Write("Informe o tamanho do cateto a: ");
            string aStr = Console.ReadLine();
            double a = double.Parse(aStr);

            Console.Write("Informe o tamanho do cateto b: ");
            string bStr = Console.ReadLine();
            double b = double.Parse(bStr);

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("c = {0}", c);
        }
    }

    class EX1_d
    {
        public static void Run()
        {
            Console.WriteLine("Informe um numero: ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            if (n < 0 && n % 2 != 0)
            {
                return;
            }

            Console.WriteLine(Math.Sqrt(n));
        }
    }

    class EX1_e
    {
        public static void Run()
        {
            Console.WriteLine("Informe um numero: ");
            string n1Str = Console.ReadLine();
            int n1 = int.Parse(n1Str);

            Console.WriteLine("Informe um numero: ");
            string n2Str = Console.ReadLine();
            int n2 = int.Parse(n2Str);

            if (n1 > n2)
            {
                Console.WriteLine(n1);
                return;
            }

            if (n2 > n1)
            {
                Console.WriteLine(n2);
                return;
            }

            Console.WriteLine("Os numeros são iguais");
        }
    }

    class EX1_f
    {
        public static void Run()
        {
            Console.Write("Informe um numer: ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            string dia = "Inválido";

            switch (n)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-feira";
                    break;
                case 3:
                    dia = "Terça-feira";
                    break;
                case 4:
                    dia = "Quarta-feira";
                    break;
                case 5:
                    dia = "Quinta-feira";
                    break;
                case 6:
                    dia = "Sexta-feira";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
            }

            Console.WriteLine(dia);
        }

    }

    class EX1_g
    {
        public static void Run()
        {
            Console.Write("Informe um numero: ");
            string n1str = Console.ReadLine();
            int n1 = int.Parse(n1str);

            Console.Write("Informe um numero: ");
            string n2str = Console.ReadLine();
            int n2 = int.Parse(n2str);

            Console.Write("Informe um operador: ");
            string operador = Console.ReadLine();
            operador = operador.Trim();

            int result = 0;
            switch (operador)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Operador Invalido");
                    return;
            }


            Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, result);
        }
    }

    class Ex1_h
    {
        public static void Run()
        {
            Console.Write("Informe um numero: ");
            string n1str = Console.ReadLine();
            int n1 = int.Parse(n1str);

            bool isMod3 = n1 % 3 == 0;
            bool isMod5 = n1 % 5 == 0;

            if (isMod3 && isMod5)
            {
                return;
            }

            if (isMod3)
            {
                Console.WriteLine("É divisivel por 3");
                return;
            }

            if (isMod5)
            {
                Console.WriteLine("É divisivel por 5");
                return;
            }
        }
    }

    class Ex1_i
    {
        public static void Run()
        {
            Console.Write("Informe distancia percorrida em km: ");
            string distanciaStr = Console.ReadLine();
            double distancia = double.Parse(distanciaStr);

            Console.Write("Informe a quantidade de litros de gasolina consumidos em L: ");
            string litrosStr = Console.ReadLine();
            double litros = double.Parse(litrosStr);

            double consumo = distancia / litros;

            if (consumo > 14)
            {
                Console.WriteLine("Venda o carro ou compre um posto!");
                return;
            }

            if (consumo < 8)
            {
                Console.WriteLine("Super economico!");
                return;
            }

            Console.WriteLine("Economico!");
        }
    }

    class EX1_j
    {
        public static void Run()
        {
            Console.Write("Informe um numero");
            string n1str = Console.ReadLine();
            int x = int.Parse(n1str);

            Console.Write("Informe um numero");
            string n2str = Console.ReadLine();
            int y = int.Parse(n2str);

            Console.Write("Informe um numero");
            string n3str = Console.ReadLine();
            int z = int.Parse(n3str);

            int ponderada = (x + 2 * y + 3 * z) / 6;
            int harmonica = 1 / ((1 / x) + (1 / y) + (1 / z));
            int aritmetica = (x + y + z) / 3;

            Console.WriteLine("a) {0}", ponderada);
            Console.WriteLine("b) {0}", harmonica);
            Console.WriteLine("c) {0}", aritmetica);
        }
    }

    class EX1_k
    {
        public static void Run()
        {
            Console.Write("Informe a quantidade vendida: ");
            string vendidoStr = Console.ReadLine();
            double vendido = double.Parse(vendidoStr);

            double comissao = EX1_k.calculaComissao(vendido);

            Console.WriteLine("Valor da comissão {0}", comissao);
        }

        public static double calculaComissao(double vendido)
        {
            if (vendido >= 100000)
            {
                return (vendido * 0.16) + 700;
            }
            else if (vendido < 100000 && vendido >= 80000)
            {
                return (vendido * 0.14) + 650;
            }
            else if (vendido < 80000 && vendido >= 60000)
            {
                return (vendido * 0.14) + 600;
            }
            else if (vendido < 60000 && vendido >= 40000)
            {
                return (vendido * 0.14) + 550;
            }
            else if (vendido < 40000 && vendido >= 20000)
            {
                return (vendido * 0.14) + 500;
            }
            else if (vendido < 20000)
            {
                return (vendido * 0.14) * 400;
            }

            return 0.0;
        }
    }

}
